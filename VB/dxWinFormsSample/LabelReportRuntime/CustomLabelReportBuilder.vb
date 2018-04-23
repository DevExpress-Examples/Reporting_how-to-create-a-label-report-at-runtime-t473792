Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraReports.Wizards
Imports DevExpress.XtraPrinting
Imports System.Drawing.Printing
Imports System
Imports DevExpress.XtraReports.Wizards.Labels
Imports System.Linq
Imports System.Drawing
Imports DevExpress.XtraPrinting.Native

Namespace dxWinFormsSample
    Public Class CustomLabelReportBuilder
        Public Sub New()
        End Sub
        Public Function GenerateLabelReport(ByVal width As Single, ByVal height As Single, ByVal vPitch As Single, ByVal hPitch As Single, ByVal measurementUnit As System.Drawing.GraphicsUnit, ByVal bottomMargin As Single, ByVal topMargin As Single, ByVal leftMargin As Single, ByVal rightMargin As Single, ByVal paperKindID As Integer) As XtraReport
            Dim model As New CustomLabelReportModel()
            model.LabelWidth = width
            model.LabelHeight = height
            model.VerticalPitch = vPitch
            model.HorizontalPitch = hPitch
            model.MeasurementUnit = measurementUnit
            model.BottomMargin = bottomMargin
            model.LeftMargin = leftMargin
            model.TopMargin = topMargin
            model.RightMargin = rightMargin
            model.PaperKindID = paperKindID
            Return BuildLabelReport(model)
        End Function
        Public Function GenerateLabelReport(ByVal model As CustomLabelReportModel) As XtraReport
            Return BuildLabelReport(model)
        End Function
        Private Function BuildLabelReport(ByVal model As CustomLabelReportModel) As XtraReport
            Dim report = New XtraReport()
            Dim paperKindList As PaperKindList = InitPaperKindList(model, report)
            report.ReportUnit = If(model.MeasurementUnit = System.Drawing.GraphicsUnit.Millimeter, ReportUnit.TenthsOfAMillimeter, ReportUnit.HundredthsOfAnInch)
            report.PaperKind = paperKindList.PaperKind
            report.Landscape = paperKindList.Landscape
            report.RollPaper = False
            Dim labelDpi As Single = GraphicsDpi.UnitToDpi(model.MeasurementUnit)
            Dim top As Integer = CInt((XRConvert.Convert(model.TopMargin, labelDpi, report.Dpi)))
            Dim left As Integer = CInt((XRConvert.Convert(model.LeftMargin, labelDpi, report.Dpi)))
            Dim right As Integer = CInt((XRConvert.Convert(model.RightMargin, labelDpi, report.Dpi)))
            Dim bottom As Integer = CInt((XRConvert.Convert(model.BottomMargin, labelDpi, report.Dpi)))
            report.Margins = New Margins(left, right, top, bottom)
            Dim labelWidth As Single = XRConvert.Convert(model.LabelWidth, labelDpi, report.Dpi)
            Dim labelHeight As Single = XRConvert.Convert(model.LabelHeight, labelDpi, report.Dpi)
            Dim detail As New DetailBand()
            report.Bands.Add(detail)
            Dim panel As New XRPanel()
            panel.CanGrow = False
            detail.Controls.Add(panel)
            panel.WidthF = labelWidth
            panel.HeightF = labelHeight
            panel.Borders = BorderSide.All
            detail.HeightF = XRConvert.Convert(model.VerticalPitch, labelDpi, report.Dpi)

            Dim labelInfo = DevExpress.XtraReports.Wizards.Builder.LabelInfoFactory.Create(GetDefaultLabelReportMode(model))
            report.ReportPrintOptions.DetailCountOnEmptyDataSource = labelInfo.CalculateLabelCount(paperKindList.Size, paperKindList.UnitDpi)
            If labelInfo.MoreOneColumnOnPage(paperKindList.Size, paperKindList.UnitDpi) Then
                detail.MultiColumn.ColumnWidth = XRConvert.Convert(labelInfo.LabelWidth, labelDpi, report.Dpi)
                detail.MultiColumn.ColumnSpacing = XRConvert.Convert(labelInfo.HPitch - labelInfo.LabelWidth, labelDpi, report.Dpi)
                detail.MultiColumn.Layout = ColumnLayout.AcrossThenDown
            End If
            Return report
        End Function
        Private Function GetDefaultLabelReportMode(ByVal model As CustomLabelReportModel) As ReportModel
            Dim reportModel As New XtraReportModel()
            reportModel.ReportType = ReportType.Label
            Dim customLblInfo = New CustomLabelInformation()
            customLblInfo.Height = model.LabelHeight
            customLblInfo.Width = model.LabelWidth
            customLblInfo.TopMargin = model.TopMargin
            customLblInfo.BottomMargin = model.BottomMargin
            customLblInfo.LeftMargin = model.LeftMargin
            customLblInfo.RightMargin = model.RightMargin
            customLblInfo.VerticalPitch = model.VerticalPitch
            customLblInfo.HorizontalPitch = model.HorizontalPitch
            customLblInfo.PaperKindDataId = model.PaperKindID
            customLblInfo.Unit = model.MeasurementUnit
            reportModel.CustomLabelInformation = customLblInfo
            Return reportModel
        End Function
        Private Shared Function InitPaperKindList(ByVal model As CustomLabelReportModel, ByVal report As XtraReport) As PaperKindList
            Dim paperKindList = New PaperKindList(report.Dpi)
            Dim labelRepository = (New LabelProductRepositoryFactory()).Create()
            Dim paperKindItems = labelRepository.GetSortedPaperKinds().Select(AddressOf ConvertToPaperKindItem)
            For Each item In paperKindItems
                paperKindList.Add(item)
            Next item
            paperKindList.CurrentID = model.PaperKindID
            Return paperKindList
        End Function
        Private Shared Function ConvertToPaperKindItem(ByVal paperKindData As PaperKindData) As PaperKindItem
            Dim dpi As Single = DevExpress.XtraPrinting.GraphicsDpi.UnitToDpi(paperKindData.Unit)
            Dim paperKind = CType(paperKindData.EnumId, PaperKind)
            Dim size As SizeF = If(paperKind = System.Drawing.Printing.PaperKind.Custom, New SizeF(paperKindData.Width, paperKindData.Height), PageSizeInfo.GetPageSizeF(paperKind, dpi, PageSizeInfo.DefaultSize))
            Return New PaperKindItem(paperKindData.Name, size, paperKindData.Id, paperKind, dpi, paperKindData.IsRollPaper)
        End Function
    End Class
End Namespace
