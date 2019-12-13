namespace dxWinFormsSample {
    public class CustomLabelReportModel {
        public float LabelWidth { get; set; } 
        public float LabelHeight { get; set; } 
        public float VerticalPitch { get; set; }
        public float HorizontalPitch { get; set; }

        private System.Drawing.GraphicsUnit _Unit = System.Drawing.GraphicsUnit.Millimeter;
        public System.Drawing.GraphicsUnit MeasurementUnit { get { return _Unit; } set { _Unit = value; } }
        public float BottomMargin { get; set; }
        public float TopMargin { get; set; }
        public float LeftMargin { get; set; }
        public float RightMargin { get; set; }
        public int PaperKindID { get; set; }

    }
}
