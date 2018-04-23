using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.Wizards;
using DevExpress.XtraPrinting;
using System.Drawing.Printing;
using System;
using DevExpress.XtraReports.Wizards.Labels;
using System.Linq;
using System.Drawing;
using DevExpress.XtraPrinting.Native;

namespace dxWinFormsSample {
    public class CustomLabelReportBuilder  {
        public CustomLabelReportBuilder() { }
        public XtraReport GenerateLabelReport(float width, float height, float vPitch, float hPitch, System.Drawing.GraphicsUnit measurementUnit, float bottomMargin, float topMargin, float leftMargin, float rightMargin, int paperKindID) {
            CustomLabelReportModel model = new CustomLabelReportModel();
            model.LabelWidth = width;
            model.LabelHeight = height;
            model.VerticalPitch = vPitch;
            model.HorizontalPitch = hPitch;
            model.MeasurementUnit = measurementUnit;
            model.BottomMargin = bottomMargin;
            model.LeftMargin = leftMargin;
            model.TopMargin = topMargin;
            model.RightMargin = rightMargin;
            model.PaperKindID = paperKindID;
            return BuildLabelReport(model);
        }
        public XtraReport GenerateLabelReport(CustomLabelReportModel model) {
            return BuildLabelReport(model);
        }        
        private XtraReport BuildLabelReport(CustomLabelReportModel model) {
            var report = new XtraReport();
            PaperKindList paperKindList = InitPaperKindList(model, report);
            report.ReportUnit = model.MeasurementUnit == System.Drawing.GraphicsUnit.Millimeter ? ReportUnit.TenthsOfAMillimeter : ReportUnit.HundredthsOfAnInch;
            report.PaperKind = paperKindList.PaperKind;
            report.Landscape = paperKindList.Landscape;
            report.RollPaper = false;
            float labelDpi = GraphicsDpi.UnitToDpi(model.MeasurementUnit);
            int top = (int)XRConvert.Convert(model.TopMargin, labelDpi, report.Dpi);
            int left = (int)XRConvert.Convert(model.LeftMargin, labelDpi, report.Dpi);
            int right = (int)XRConvert.Convert(model.RightMargin, labelDpi, report.Dpi);
            int bottom = (int)XRConvert.Convert(model.BottomMargin, labelDpi, report.Dpi);
            report.Margins = new Margins(left, right, top, bottom);
            float labelWidth = XRConvert.Convert(model.LabelWidth, labelDpi, report.Dpi);
            float labelHeight = XRConvert.Convert(model.LabelHeight, labelDpi, report.Dpi);
            DetailBand detail = new DetailBand();
            report.Bands.Add(detail);
            XRPanel panel = new XRPanel();
            panel.CanGrow = false;
            detail.Controls.Add(panel);
            panel.WidthF = labelWidth;
            panel.HeightF = labelHeight;
            panel.Borders = BorderSide.All;
            detail.HeightF = XRConvert.Convert(model.VerticalPitch, labelDpi, report.Dpi);

            var labelInfo = DevExpress.XtraReports.Wizards.Builder.LabelInfoFactory.Create(GetDefaultLabelReportMode(model));
            report.ReportPrintOptions.DetailCountOnEmptyDataSource = labelInfo.CalculateLabelCount(paperKindList.Size, paperKindList.UnitDpi);
            if (labelInfo.MoreOneColumnOnPage(paperKindList.Size, paperKindList.UnitDpi)) {
                detail.MultiColumn.ColumnWidth = XRConvert.Convert(labelInfo.LabelWidth, labelDpi, report.Dpi);
                detail.MultiColumn.ColumnSpacing = XRConvert.Convert(labelInfo.HPitch - labelInfo.LabelWidth, labelDpi, report.Dpi);
                detail.MultiColumn.Layout = ColumnLayout.AcrossThenDown;
            }
            return report;
        }
        private ReportModel GetDefaultLabelReportMode(CustomLabelReportModel model) {
            XtraReportModel reportModel = new XtraReportModel();
            reportModel.ReportType = ReportType.Label;
            var customLblInfo = new CustomLabelInformation();
            customLblInfo.Height = model.LabelHeight;
            customLblInfo.Width = model.LabelWidth;
            customLblInfo.TopMargin = model.TopMargin;
            customLblInfo.BottomMargin = model.BottomMargin;
            customLblInfo.LeftMargin = model.LeftMargin;
            customLblInfo.RightMargin = model.RightMargin;
            customLblInfo.VerticalPitch = model.VerticalPitch;
            customLblInfo.HorizontalPitch = model.HorizontalPitch;
            customLblInfo.PaperKindDataId = model.PaperKindID;
            customLblInfo.Unit = model.MeasurementUnit;
            reportModel.CustomLabelInformation = customLblInfo;
            return reportModel;
        }
        private static PaperKindList InitPaperKindList(CustomLabelReportModel model, XtraReport report) {
            var paperKindList = new PaperKindList(report.Dpi);
            var labelRepository = new LabelProductRepositoryFactory().Create();
            var paperKindItems = labelRepository
                .GetSortedPaperKinds()
                .Select(ConvertToPaperKindItem);
            foreach (var item in paperKindItems) {
                paperKindList.Add(item);
            }
            paperKindList.CurrentID = model.PaperKindID;
            return paperKindList;
        }
        static PaperKindItem ConvertToPaperKindItem(PaperKindData paperKindData) {
            float dpi = DevExpress.XtraPrinting.GraphicsDpi.UnitToDpi(paperKindData.Unit);
            var paperKind = (PaperKind)paperKindData.EnumId;
            SizeF size = paperKind == PaperKind.Custom
                ? new SizeF(paperKindData.Width, paperKindData.Height)
                : PageSizeInfo.GetPageSizeF(paperKind, dpi, PageSizeInfo.DefaultSize);
            return new PaperKindItem(paperKindData.Name, size, paperKindData.Id, paperKind, dpi, paperKindData.IsRollPaper);
        }
    }
}
