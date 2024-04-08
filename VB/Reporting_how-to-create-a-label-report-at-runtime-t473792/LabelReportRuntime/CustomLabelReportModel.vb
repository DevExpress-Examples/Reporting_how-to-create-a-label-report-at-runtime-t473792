Namespace dxWinFormsSample
    Public Class CustomLabelReportModel
        Public Property LabelWidth() As Single
        Public Property LabelHeight() As Single
        Public Property VerticalPitch() As Single
        Public Property HorizontalPitch() As Single
        Private _Unit As DevExpress.Drawing.DXGraphicsUnit = DevExpress.Drawing.DXGraphicsUnit.Millimeter
        Public Property MeasurementUnit() As DevExpress.Drawing.DXGraphicsUnit
            Get
                Return _Unit
            End Get
            Set(ByVal value As DevExpress.Drawing.DXGraphicsUnit)
                _Unit = value
            End Set
        End Property
        Public Property BottomMargin() As Single
        Public Property TopMargin() As Single
        Public Property LeftMargin() As Single
        Public Property RightMargin() As Single
        Public Property PaperKindID() As Integer

    End Class
End Namespace
