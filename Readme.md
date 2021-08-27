<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T473792)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/dxWinFormsSample/Form1.cs) (VB: [Form1.vb](./VB/dxWinFormsSample/Form1.vb))
* [CustomLabelReportBuilder.cs](./CS/dxWinFormsSample/LabelReportRuntime/CustomLabelReportBuilder.cs) (VB: [CustomLabelReportBuilder.vb](./VB/dxWinFormsSample/LabelReportRuntime/CustomLabelReportBuilder.vb))
* [CustomLabelReportModel.cs](./CS/dxWinFormsSample/LabelReportRuntime/CustomLabelReportModel.cs) (VB: [CustomLabelReportModel.vb](./VB/dxWinFormsSample/LabelReportRuntime/CustomLabelReportModel.vb))
* [LabelReportValuesHelper.cs](./CS/dxWinFormsSample/LabelReportRuntime/LabelReportValuesHelper.cs) (VB: [LabelReportValuesHelper.vb](./VB/dxWinFormsSample/LabelReportRuntime/LabelReportValuesHelper.vb))
* [Program.cs](./CS/dxWinFormsSample/Program.cs) (VB: [Program.vb](./VB/dxWinFormsSample/Program.vb))
<!-- default file list end -->
# How to create a label report at runtime


<p>This example demonstrates how to create a <a href="https://documentation.devexpress.com/XtraReports/CustomDocument4792.aspx">label report</a> at runtime. <br><br>A label report is nothing but a report with layout settings adjusted according to a selected label type. Base layout settings include page settings (the width & height, margins), a Detail band's settings (height) and <a href="https://documentation.devexpress.com/#XtraReports/CustomDocument2601">multi-column options</a>. Obviously, a different label report type requires a specific combination of report settings which may be difficult to figure out.<br><br>In this example, we implemented a special <strong>CustomLabelReportBuilder </strong>helper class that replicates the report creation code used internally by our <a href="https://documentation.devexpress.com/#InterfaceElementsWin/CustomDocument5036">Label Report Wizard</a>. For convenience, we created a <strong>CustomLabelReportModel</strong> class that provides label report specific settings that are required for building of a label report. These are the following.<br><br></p>
<p><strong>LabelWidth and LabelHeight</strong></p>
<p>Specify the width & height of <a href="https://documentation.devexpress.com/#XtraReports/clsDevExpressXtraReportsUIXRPaneltopic">XRPanel</a> placed into the <strong>Detail</strong> report band;<br><strong><br>HorizontalPitch <br></strong>Used to specify the Detail band's Multi-Column options: <a href="https://documentation.devexpress.com/#XtraReports/DevExpressXtraReportsUIMultiColumn_ColumnWidthtopic">MultiColumn.ColumnWidth</a> and <a href="https://documentation.devexpress.com/#XtraReports/DevExpressXtraReportsUIMultiColumn_ColumnSpacingtopic">MultiColumn.ColumnSpacing</a>.</p>
<p><strong><br>VerticalPitch<br></strong>Is assigned to the <a href="https://documentation.devexpress.com/#XtraReports/DevExpressXtraReportsUIXRControl_Heighttopic">DetailBand.Height</a> property.<br><strong><br>MeasurementUnit </strong><br>Is assigned to the <a href="https://documentation.devexpress.com/#XtraReports/DevExpressXtraReportsUIXtraReport_ReportUnittopic">XtraReport.ReportUnit</a> property.<br><br><strong>PaperKindID</strong> <br>Specifies an ID that becomes converted to a corresponding System.Drawing.Printing.PaperKind enumeration value assigned to the <a href="https://documentation.devexpress.com/#XtraReports/DevExpressXtraReportsUIXtraReport_PaperKindtopic">XtraReport.PaperKind</a> property.<br><br></p>
<p><strong>TopMargin and LeftMargin<br></strong>Are assigned to the Top and Left <a href="https://documentation.devexpress.com/#XtraReports/DevExpressXtraReportsUIXtraReport_Marginstopic">report margins</a>.<br><br></p>
<p><strong>BottomMargin and RightMargin</strong><br>These are empty spaces that appear on the resulting report's page as right and bottom spaces. These values are calculated automatically based on other settings.<br><br>So, to generate a label report at runtime, call <strong>CustomLabelReportBuilder.GenerateLabelReport </strong>with a CustomLabelReportModel object or individual settings (listed above) as an argument(s). <br><br>Take note of the LabelReportValuesHelper class - it has methods that allow you to fetch label report type settings, such as the Label Products list and Product Details. <br><br>Keep in mind that you can provide custom XML with available Label Product values. To do so, pass a path to the custom XML to the LabelReportValuesHelper constructor.<br>For the default Label Report Wizard to use this custom XML as well, specify the static DevExpress.Data.XtraReports.Labels.LabelWizardCustomization.ExternalLabelProductRepository property at the application startup.</p>

<br/>


