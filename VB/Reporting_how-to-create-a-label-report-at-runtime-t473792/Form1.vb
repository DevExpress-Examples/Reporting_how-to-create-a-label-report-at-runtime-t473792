Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraReports.UI
Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports System.Linq
Imports DevExpress.XtraEditors
Imports DevExpress.XtraReports.Wizards.Labels
Imports System.Drawing

Namespace dxWinFormsSample
    Partial Public Class Form1
        Inherits DevExpress.XtraEditors.XtraForm


        Private helper_Renamed As LabelReportValuesHelper
        Public Sub New()
            InitializeComponent()
        End Sub
        Private Sub btnBuildReport_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnBuildReport.Click
            Dim labelReport As XtraReport = CreateLabelReport()
            ShowDesigner(labelReport)
        End Sub
        Private Function CreateLabelReport() As XtraReport
            Dim builder As New CustomLabelReportBuilder()
            Dim labelReport As XtraReport = builder.GenerateLabelReport(Convert.ToSingle(LabelWidthSpinEdit.EditValue), Convert.ToSingle(LabelHeightSpinEdit.EditValue), Convert.ToSingle(VerticalPitchSpinEdit.EditValue), Convert.ToSingle(HorizontalPitchSpinEdit.EditValue), DirectCast(UnitComboBox.EditValue, DevExpress.Drawing.DXGraphicsUnit), Convert.ToSingle(BottomMarginSpinEdit.EditValue), Convert.ToSingle(TopMarginSpinEdit.EditValue), Convert.ToSingle(LeftMarginSpinEdit.EditValue), Convert.ToSingle(RightMarginSpinEdit.EditValue), Convert.ToInt32(lookUpPaperType.EditValue))
            Return labelReport
        End Function
        Private Shared Sub ShowDesigner(ByVal labelReport As XtraReport)
            If labelReport Is Nothing Then
                labelReport = New XtraReport()
            End If
            Call (New ReportDesignTool(labelReport)).ShowRibbonDesignerDialog(DevExpress.LookAndFeel.UserLookAndFeel.Default)
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
            helper_Renamed = New LabelReportValuesHelper()
            InitLabelProductEditor()
            InitProductNumberEditor()
            InitUnitEditor()
            InitPaperTypeEditor()
        End Sub
        Private Sub InitUnitEditor()
            UnitComboBox.Properties.Items.AddRange(New System.Drawing.GraphicsUnit() {System.Drawing.GraphicsUnit.Inch, System.Drawing.GraphicsUnit.Millimeter})
            UnitComboBox.EditValue = System.Drawing.GraphicsUnit.Millimeter
        End Sub
        Private Sub InitLabelProductEditor()
            lookUpLabelProduct.Properties.BeginInit()
            lookUpLabelProduct.Properties.DataSource = helper_Renamed.GetLabelProducts().ToList()
            lookUpLabelProduct.Properties.View.OptionsBehavior.AutoPopulateColumns = False
            lookUpLabelProduct.Properties.View.OptionsView.ShowColumnHeaders = False
            lookUpLabelProduct.Properties.View.OptionsView.ShowIndicator = False
            Dim col1 As GridColumn = lookUpLabelProduct.Properties.View.Columns.AddField("Name")
            col1.VisibleIndex = 0
            lookUpLabelProduct.Properties.DisplayMember = "Name"
            lookUpLabelProduct.Properties.ValueMember = "Id"
            AddHandler lookUpLabelProduct.EditValueChanged, AddressOf LookUpLabelProduct_EditValueChanged
            lookUpLabelProduct.Properties.EndInit()
            lookUpLabelProduct.EditValue = 1
        End Sub
        Private Sub InitProductNumberEditor()
            lookUpProductNumber.Properties.View.OptionsBehavior.AutoPopulateColumns = False
            lookUpProductNumber.Properties.View.OptionsView.ShowColumnHeaders = False
            lookUpProductNumber.Properties.View.OptionsView.ShowIndicator = False
            Dim col1 As GridColumn = lookUpProductNumber.Properties.View.Columns.AddField("Name")
            col1.VisibleIndex = 0
            lookUpProductNumber.Properties.DisplayMember = "Name"
            lookUpProductNumber.Properties.ValueMember = "Id"
            AddHandler lookUpProductNumber.EditValueChanged, AddressOf LookUpProductNumber_EditValueChanged
        End Sub
        Private Sub InitPaperTypeEditor()
            lookUpPaperType.Properties.DataSource = helper_Renamed.GetPaperKinds().ToList()
            lookUpPaperType.Properties.DisplayMember = "Name"
            lookUpPaperType.Properties.ValueMember = "Id"
            lookUpPaperType.Properties.View.OptionsBehavior.AutoPopulateColumns = False
            lookUpPaperType.Properties.View.OptionsView.ShowColumnHeaders = False
            lookUpPaperType.Properties.View.OptionsView.ShowIndicator = False
            Dim col1 As GridColumn = lookUpPaperType.Properties.View.Columns.AddField("Name")
            col1.VisibleIndex = 0
        End Sub

        Private Sub LookUpLabelProduct_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim labelProduct As Integer = 1
            Int32.TryParse((TryCast(sender, BaseEdit)).EditValue.ToString(), labelProduct)
            Dim sortedProductDetails As IEnumerable(Of LabelDetails) = helper_Renamed.GetProductDetails(labelProduct)
            lookUpProductNumber.Properties.DataSource = sortedProductDetails.ToList()
            BeginInvoke(CType(Sub()
                                  lookUpProductNumber.EditValue = (TryCast(lookUpProductNumber.Properties.DataSource, List(Of LabelDetails))).First().Id

                              End Sub, MethodInvoker))
        End Sub
        Private Sub LookUpProductNumber_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim gridLookUpEdt = (TryCast(sender, GridLookUpEdit))
            Dim selectedRow = gridLookUpEdt.GetSelectedDataRow()
            If selectedRow Is Nothing Then
                Return
            End If
            Dim ld As LabelDetails = TryCast(selectedRow, LabelDetails)
            lookUpPaperType.EditValue = ld.PaperKindId
            FillModel(ld)
        End Sub
        Private Sub FillModel(ByVal ld As LabelDetails)
            LabelWidthSpinEdit.EditValue = ld.Width
            LabelHeightSpinEdit.EditValue = ld.Height
            VerticalPitchSpinEdit.EditValue = ld.VPitch
            HorizontalPitchSpinEdit.EditValue = ld.HPitch
            BottomMarginSpinEdit.EditValue = ld.BottomMargin
            TopMarginSpinEdit.EditValue = ld.TopMargin
            LeftMarginSpinEdit.EditValue = ld.LeftMargin
            RightMarginSpinEdit.EditValue = ld.RightMargin
            UnitComboBox.EditValue = ld.Unit
        End Sub
        Private Sub ConvertValues(ByVal unit As GraphicsUnit, ByVal lblWidth As Object, ByVal lblHeight As Object, ByVal vPitch As Object, ByVal hPitch As Object, ByVal bottomMargin As Object, ByVal topMargin As Object, ByVal leftMargin As Object, ByVal rightMargin As Object)
            If unit = GraphicsUnit.Millimeter Then
                LabelWidthSpinEdit.EditValue = LabelReportValuesHelper.ConvertInchToMillimeter(Convert.ToSingle(lblWidth))
                LabelHeightSpinEdit.EditValue = LabelReportValuesHelper.ConvertInchToMillimeter(Convert.ToSingle(lblHeight))
                VerticalPitchSpinEdit.EditValue = LabelReportValuesHelper.ConvertInchToMillimeter(Convert.ToSingle(vPitch))
                HorizontalPitchSpinEdit.EditValue = LabelReportValuesHelper.ConvertInchToMillimeter(Convert.ToSingle(hPitch))
                BottomMarginSpinEdit.EditValue = LabelReportValuesHelper.ConvertInchToMillimeter(Convert.ToSingle(bottomMargin))
                TopMarginSpinEdit.EditValue = LabelReportValuesHelper.ConvertInchToMillimeter(Convert.ToSingle(topMargin))
                LeftMarginSpinEdit.EditValue = LabelReportValuesHelper.ConvertInchToMillimeter(Convert.ToSingle(leftMargin))
                RightMarginSpinEdit.EditValue = LabelReportValuesHelper.ConvertInchToMillimeter(Convert.ToSingle(rightMargin))
            Else
                If unit = GraphicsUnit.Inch Then
                    LabelWidthSpinEdit.EditValue = LabelReportValuesHelper.ConvertMillimeterToInch(Convert.ToSingle(lblWidth))
                    LabelHeightSpinEdit.EditValue = LabelReportValuesHelper.ConvertMillimeterToInch(Convert.ToSingle(lblHeight))
                    VerticalPitchSpinEdit.EditValue = LabelReportValuesHelper.ConvertMillimeterToInch(Convert.ToSingle(vPitch))
                    HorizontalPitchSpinEdit.EditValue = LabelReportValuesHelper.ConvertMillimeterToInch(Convert.ToSingle(hPitch))
                    BottomMarginSpinEdit.EditValue = LabelReportValuesHelper.ConvertMillimeterToInch(Convert.ToSingle(bottomMargin))
                    TopMarginSpinEdit.EditValue = LabelReportValuesHelper.ConvertMillimeterToInch(Convert.ToSingle(topMargin))
                    LeftMarginSpinEdit.EditValue = LabelReportValuesHelper.ConvertMillimeterToInch(Convert.ToSingle(leftMargin))
                    RightMarginSpinEdit.EditValue = LabelReportValuesHelper.ConvertMillimeterToInch(Convert.ToSingle(rightMargin))
                End If
            End If
        End Sub

        Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs)
            Call (New ReportDesignTool(New XtraReport())).ShowRibbonDesignerDialog()
        End Sub

        Private Sub UnitComboBox_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles UnitComboBox.SelectedIndexChanged
            If (TryCast(sender, BaseEdit)).EditValue IsNot Nothing AndAlso TypeOf (TryCast(sender, BaseEdit)).EditValue Is GraphicsUnit Then
                ConvertValues(DirectCast((TryCast(sender, BaseEdit)).EditValue, GraphicsUnit), LabelWidthSpinEdit.EditValue, LabelHeightSpinEdit.EditValue, VerticalPitchSpinEdit.EditValue, HorizontalPitchSpinEdit.EditValue, BottomMarginSpinEdit.EditValue, TopMarginSpinEdit.EditValue, LeftMarginSpinEdit.EditValue, RightMarginSpinEdit.EditValue)
            End If
        End Sub
    End Class
End Namespace

