Imports DevExpress.XtraReports.Wizards.Labels
Imports System.Collections.Generic
Imports System.IO
Imports System.Xml.Linq

Namespace dxWinFormsSample
    Public Class LabelReportValuesHelper
        Private repository As XDocumentLabelProductRepository
        ''' <summary>
        '''This class prodives methods that allow you to fetch label report type settings such as Label Products list and Product Details.
        '''Keep in mind that you can provide a custom XML with available Label Product values.
        '''To do so, pass a path to the custom XML to the LabelReportValuesHelper constructor.
        '''
        '''For the default Label Report Wizard to use this custom XML as well, specify the static DevExpress.Data.XtraReports.Labels.LabelWizardCustomization.ExternalLabelProductRepository property at the application startup.
        ''' </summary>
        Private Const defaultExternalLabelProductRepository As String = "Labels.xml"
        Public Sub New()
            Me.New(defaultExternalLabelProductRepository)
        End Sub
        Public Sub New(ByVal xMLFilePath As String)
            If String.IsNullOrEmpty(xMLFilePath) Then
                xMLFilePath = defaultExternalLabelProductRepository
            End If
            Dim type = GetType(LabelProductRepositoryFactory)
            Dim assembly = type.Assembly
            Dim stream As Stream = assembly.GetManifestResourceStream(type, xMLFilePath)
            repository = New XDocumentLabelProductRepository(XDocument.Load(DevExpress.Utils.SafeXml.CreateReader(stream)))
        End Sub
        Public Function GetProductDetails(ByVal productValue As Integer) As IEnumerable(Of LabelDetails)
            Return repository.GetSortedProductDetails(productValue)
        End Function
        Public Function GetLabelProducts() As IEnumerable(Of LabelProduct)
            Return repository.GetSortedProducts()
        End Function
        Public Function GetPaperKinds() As IEnumerable(Of PaperKindData)
            Return repository.GetSortedPaperKinds()
        End Function
        Public Function GetPaperKindData(ByVal id As Integer) As PaperKindData
            Return repository.GetPaperKindData(id)
        End Function
        Public Shared Function ConvertMillimeterToInch(ByVal ld As Single) As Single
            Return DevExpress.XtraPrinting.GraphicsUnitConverter.Convert(ld, System.Drawing.GraphicsUnit.Millimeter, System.Drawing.GraphicsUnit.Inch)
        End Function
        Public Shared Function ConvertInchToMillimeter(ByVal ld As Single) As Single
            Return DevExpress.XtraPrinting.GraphicsUnitConverter.Convert(ld, System.Drawing.GraphicsUnit.Inch, System.Drawing.GraphicsUnit.Millimeter)
        End Function
    End Class
End Namespace
