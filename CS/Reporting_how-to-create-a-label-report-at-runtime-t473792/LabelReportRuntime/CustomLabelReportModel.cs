using DevExpress.Drawing;

namespace dxWinFormsSample {
    public class CustomLabelReportModel {
        public float LabelWidth { get; set; } 
        public float LabelHeight { get; set; } 
        public float VerticalPitch { get; set; }
        public float HorizontalPitch { get; set; }

        private DXGraphicsUnit _Unit = DXGraphicsUnit.Millimeter;
        public DXGraphicsUnit MeasurementUnit { get { return _Unit; } set { _Unit = value; } }
        public float BottomMargin { get; set; }
        public float TopMargin { get; set; }
        public float LeftMargin { get; set; }
        public float RightMargin { get; set; }
        public int PaperKindID { get; set; }

    }
}
