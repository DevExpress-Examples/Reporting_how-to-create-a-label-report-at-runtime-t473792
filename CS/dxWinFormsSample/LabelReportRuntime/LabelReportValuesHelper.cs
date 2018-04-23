using DevExpress.XtraReports.Wizards.Labels;
using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;

namespace dxWinFormsSample {
    public class LabelReportValuesHelper {
        private XDocumentLabelProductRepository repository;
        /// <summary>
        ///This class prodives methods that allow you to fetch label report type settings such as Label Products list and Product Details.
        ///Keep in mind that you can provide a custom XML with available Label Product values.
        ///To do so, pass a path to the custom XML to the LabelReportValuesHelper constructor.
        ///
        ///For the default Label Report Wizard to use this custom XML as well, specify the static DevExpress.Data.XtraReports.Labels.LabelWizardCustomization.ExternalLabelProductRepository property at the application startup.
        /// </summary>
        private const string defaultExternalLabelProductRepository = "Labels.xml";
        public LabelReportValuesHelper():this(defaultExternalLabelProductRepository){
        }
        public LabelReportValuesHelper(string xMLFilePath) {
            if (string.IsNullOrEmpty(xMLFilePath))
                xMLFilePath = defaultExternalLabelProductRepository;
            var type = typeof(LabelProductRepositoryFactory);
            var assembly = type.Assembly;
            Stream stream = assembly.GetManifestResourceStream(type, xMLFilePath);
            repository = new XDocumentLabelProductRepository(XDocument.Load(DevExpress.Utils.SafeXml.CreateReader(stream)));
        }
        public IEnumerable<LabelDetails> GetProductDetails(int productValue) {
            return repository.GetSortedProductDetails(productValue);
        }
        public IEnumerable<LabelProduct> GetLabelProducts() {
            return repository.GetSortedProducts();
        }
        public IEnumerable<PaperKindData> GetPaperKinds() {
            return repository.GetSortedPaperKinds();
        }
        public PaperKindData GetPaperKindData(int id) {
            return repository.GetPaperKindData(id);
        }
        public static float ConvertMillimeterToInch(float ld) {
            return DevExpress.XtraPrinting.GraphicsUnitConverter.Convert(ld, System.Drawing.GraphicsUnit.Millimeter, System.Drawing.GraphicsUnit.Inch);
        }
        public static float ConvertInchToMillimeter(float ld) {
            return DevExpress.XtraPrinting.GraphicsUnitConverter.Convert(ld, System.Drawing.GraphicsUnit.Inch, System.Drawing.GraphicsUnit.Millimeter);
        }
    }
}
