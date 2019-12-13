using DevExpress.XtraGrid.Columns;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.Wizards.Labels;
using System.Drawing;

namespace dxWinFormsSample {
    public partial class Form1 : DevExpress.XtraEditors.XtraForm {
        private LabelReportValuesHelper helper;       
        public Form1() {
            InitializeComponent();
        }
        private void btnBuildReport_Click(object sender, EventArgs e) {
            XtraReport labelReport = CreateLabelReport();
            ShowDesigner(labelReport);
        }
        private XtraReport CreateLabelReport() {                       
            CustomLabelReportBuilder builder = new CustomLabelReportBuilder();
            XtraReport labelReport = builder.GenerateLabelReport(
                Convert.ToSingle(LabelWidthSpinEdit.EditValue),
                Convert.ToSingle(LabelHeightSpinEdit.EditValue),
                Convert.ToSingle(VerticalPitchSpinEdit.EditValue),
                Convert.ToSingle(HorizontalPitchSpinEdit.EditValue),
                (GraphicsUnit)UnitComboBox.EditValue,
                Convert.ToSingle(BottomMarginSpinEdit.EditValue),
                Convert.ToSingle(TopMarginSpinEdit.EditValue),
                Convert.ToSingle(LeftMarginSpinEdit.EditValue),
                Convert.ToSingle(RightMarginSpinEdit.EditValue),
                Convert.ToInt32(lookUpPaperType.EditValue)
                );
            return labelReport;
        }
        private static void ShowDesigner(XtraReport labelReport) {
            if (labelReport == null)
                labelReport = new XtraReport();
            new ReportDesignTool(labelReport).ShowRibbonDesignerDialog(DevExpress.LookAndFeel.UserLookAndFeel.Default);
        }
      
        private void Form1_Load(object sender, EventArgs e) {
            helper = new LabelReportValuesHelper();
            InitLabelProductEditor();
            InitProductNumberEditor();
            InitUnitEditor();
            InitPaperTypeEditor();
        }
        private void InitUnitEditor() {
            UnitComboBox.Properties.Items.AddRange(new System.Drawing.GraphicsUnit[] { System.Drawing.GraphicsUnit.Inch, System.Drawing.GraphicsUnit.Millimeter});
            UnitComboBox.EditValue = System.Drawing.GraphicsUnit.Millimeter;
        }
        private void InitLabelProductEditor() {            
            lookUpLabelProduct.Properties.BeginInit();
            lookUpLabelProduct.Properties.DataSource = helper.GetLabelProducts().ToList();
            lookUpLabelProduct.Properties.View.OptionsBehavior.AutoPopulateColumns = false;
            lookUpLabelProduct.Properties.View.OptionsView.ShowColumnHeaders = false;
            lookUpLabelProduct.Properties.View.OptionsView.ShowIndicator = false;
            GridColumn col1 = lookUpLabelProduct.Properties.View.Columns.AddField("Name");
            col1.VisibleIndex = 0;
            lookUpLabelProduct.Properties.DisplayMember = "Name";
            lookUpLabelProduct.Properties.ValueMember = "Id";
            lookUpLabelProduct.EditValueChanged += LookUpLabelProduct_EditValueChanged;
            lookUpLabelProduct.Properties.EndInit();
            lookUpLabelProduct.EditValue = 1;
        }
        private void InitProductNumberEditor() {
            lookUpProductNumber.Properties.View.OptionsBehavior.AutoPopulateColumns = false;
            lookUpProductNumber.Properties.View.OptionsView.ShowColumnHeaders = false;
            lookUpProductNumber.Properties.View.OptionsView.ShowIndicator = false;
            GridColumn col1 = lookUpProductNumber.Properties.View.Columns.AddField("Name");
            col1.VisibleIndex = 0;
            lookUpProductNumber.Properties.DisplayMember = "Name";
            lookUpProductNumber.Properties.ValueMember = "Id";
            lookUpProductNumber.EditValueChanged += LookUpProductNumber_EditValueChanged;
        }
        private void InitPaperTypeEditor() {
            lookUpPaperType.Properties.DataSource = helper.GetPaperKinds().ToList();
            lookUpPaperType.Properties.DisplayMember = "Name";
            lookUpPaperType.Properties.ValueMember = "Id";
            lookUpPaperType.Properties.View.OptionsBehavior.AutoPopulateColumns = false;
            lookUpPaperType.Properties.View.OptionsView.ShowColumnHeaders = false;
            lookUpPaperType.Properties.View.OptionsView.ShowIndicator = false;
            GridColumn col1 = lookUpPaperType.Properties.View.Columns.AddField("Name");
            col1.VisibleIndex = 0;
        }

        private void LookUpLabelProduct_EditValueChanged(object sender, EventArgs e) {
            int labelProduct = 1;
            Int32.TryParse((sender as BaseEdit).EditValue.ToString(), out labelProduct);
            IEnumerable<LabelDetails> sortedProductDetails = helper.GetProductDetails(labelProduct);
            lookUpProductNumber.Properties.DataSource = sortedProductDetails.ToList<LabelDetails>();
            BeginInvoke((MethodInvoker)delegate {
                lookUpProductNumber.EditValue = (lookUpProductNumber.Properties.DataSource as List<LabelDetails>).First<LabelDetails>().Id; ;
            });
        }
        private void LookUpProductNumber_EditValueChanged(object sender, EventArgs e) {
            var gridLookUpEdt = (sender as GridLookUpEdit);
            var selectedRow = gridLookUpEdt.GetSelectedDataRow();
            if (selectedRow == null)
                return;
            LabelDetails ld = selectedRow as LabelDetails;
            lookUpPaperType.EditValue = ld.PaperKindId;
            FillModel(ld);
        }
        private void FillModel(LabelDetails ld) {
            LabelWidthSpinEdit.EditValue = ld.Width;
            LabelHeightSpinEdit.EditValue = ld.Height;
            VerticalPitchSpinEdit.EditValue = ld.VPitch;
            HorizontalPitchSpinEdit.EditValue = ld.HPitch;
            BottomMarginSpinEdit.EditValue = ld.BottomMargin;
            TopMarginSpinEdit.EditValue = ld.TopMargin;
            LeftMarginSpinEdit.EditValue = ld.LeftMargin;
            RightMarginSpinEdit.EditValue = ld.RightMargin;
            UnitComboBox.EditValue = ld.Unit;
        }
        private void ConvertValues(GraphicsUnit unit, object lblWidth, object lblHeight, object vPitch, object hPitch, object bottomMargin, object topMargin, object leftMargin, object rightMargin) {
            if (unit == GraphicsUnit.Millimeter) {
                LabelWidthSpinEdit.EditValue = LabelReportValuesHelper.ConvertInchToMillimeter(Convert.ToSingle(lblWidth));
                LabelHeightSpinEdit.EditValue = LabelReportValuesHelper.ConvertInchToMillimeter(Convert.ToSingle(lblHeight));
                VerticalPitchSpinEdit.EditValue = LabelReportValuesHelper.ConvertInchToMillimeter(Convert.ToSingle(vPitch));
                HorizontalPitchSpinEdit.EditValue = LabelReportValuesHelper.ConvertInchToMillimeter(Convert.ToSingle(hPitch));
                BottomMarginSpinEdit.EditValue = LabelReportValuesHelper.ConvertInchToMillimeter(Convert.ToSingle(bottomMargin));
                TopMarginSpinEdit.EditValue = LabelReportValuesHelper.ConvertInchToMillimeter(Convert.ToSingle(topMargin));
                LeftMarginSpinEdit.EditValue = LabelReportValuesHelper.ConvertInchToMillimeter(Convert.ToSingle(leftMargin));
                RightMarginSpinEdit.EditValue = LabelReportValuesHelper.ConvertInchToMillimeter(Convert.ToSingle(rightMargin));
            }
            else {
                if (unit == GraphicsUnit.Inch) {
                    LabelWidthSpinEdit.EditValue = LabelReportValuesHelper.ConvertMillimeterToInch(Convert.ToSingle(lblWidth));
                    LabelHeightSpinEdit.EditValue = LabelReportValuesHelper.ConvertMillimeterToInch(Convert.ToSingle(lblHeight));
                    VerticalPitchSpinEdit.EditValue = LabelReportValuesHelper.ConvertMillimeterToInch(Convert.ToSingle(vPitch));
                    HorizontalPitchSpinEdit.EditValue = LabelReportValuesHelper.ConvertMillimeterToInch(Convert.ToSingle(hPitch));
                    BottomMarginSpinEdit.EditValue = LabelReportValuesHelper.ConvertMillimeterToInch(Convert.ToSingle(bottomMargin));
                    TopMarginSpinEdit.EditValue = LabelReportValuesHelper.ConvertMillimeterToInch(Convert.ToSingle(topMargin));
                    LeftMarginSpinEdit.EditValue = LabelReportValuesHelper.ConvertMillimeterToInch(Convert.ToSingle(leftMargin));
                    RightMarginSpinEdit.EditValue = LabelReportValuesHelper.ConvertMillimeterToInch(Convert.ToSingle(rightMargin));
                }
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e) {
            new ReportDesignTool(new XtraReport()).ShowRibbonDesignerDialog();
        }

        private void UnitComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((sender as BaseEdit).EditValue != null && (sender as BaseEdit).EditValue is GraphicsUnit)
                ConvertValues((GraphicsUnit)(sender as BaseEdit).EditValue,
                LabelWidthSpinEdit.EditValue,
                LabelHeightSpinEdit.EditValue,
                VerticalPitchSpinEdit.EditValue,
                HorizontalPitchSpinEdit.EditValue,
                BottomMarginSpinEdit.EditValue,
                TopMarginSpinEdit.EditValue,
                LeftMarginSpinEdit.EditValue,
                RightMarginSpinEdit.EditValue);
        }
    }
}

