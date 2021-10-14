Imports System.Windows.Controls

Namespace WPF_Dashboard_CustomParameters.Views

    ''' <summary>
    ''' Interaction logic for MyDashboardView.xaml
    ''' </summary>
    Public Partial Class MyDashboardView
        Inherits UserControl

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub DashboardControl_CustomParameters(ByVal sender As Object, ByVal e As DevExpress.DashboardCommon.CustomParametersEventArgs)
            Dim customParameter = e.Parameters.FirstOrDefault(Function(p) p.Name Is "parameterState")
            If customParameter IsNot Nothing Then
                ' Actual value used when retrieving data from the data source.
                customParameter.Value = "Nevada"
            End If
        End Sub
    End Class
End Namespace
