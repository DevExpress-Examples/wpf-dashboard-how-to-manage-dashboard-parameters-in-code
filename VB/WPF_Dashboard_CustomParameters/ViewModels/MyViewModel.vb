Imports System
Imports DevExpress.Mvvm.DataAnnotations
Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.POCO
Imports System.Linq
Imports DevExpress.DashboardCommon
Imports System.Collections.Generic

Namespace WPF_Dashboard_CustomParameters.ViewModels
    <POCOViewModel> _
    Public Class MyViewModel
        Protected Sub New()
            'Dashboard = new SampleDashboard(); 
            Dim dashboard_Renamed As New Dashboard()
            dashboard_Renamed.LoadFromXml("Data\SampleDashboard.xml")
            dashboard_Renamed.Parameters.Add(CreateParameter())
            dashboard_Renamed.DataSources(0).Filter = "[State] In (?parameterState)"
            Dashboard = dashboard_Renamed
        End Sub
        Public Overridable Property Dashboard() As DevExpress.DashboardCommon.Dashboard
        Private Function CreateParameter() As DashboardParameter
            Dim myDashboardParameter As New DashboardParameter()
            Dim staticListLookUpSettings1 As New StaticListLookUpSettings()
            myDashboardParameter.AllowMultiselect = True
            ' Parameter values displayed in the look-up editor.
            staticListLookUpSettings1.Values = New String() { "Alabama", "Ohio", "Utah" }
            myDashboardParameter.LookUpSettings = staticListLookUpSettings1
            myDashboardParameter.Name = "parameterState"
            myDashboardParameter.Type = GetType(String)
            ' Default parameter value.
            myDashboardParameter.Value = New List(Of String) From {"Ohio", "Utah"}
            Return myDashboardParameter
		End Function
        Public Sub OnCustomParameters(ByVal e As DevExpress.DashboardCommon.CustomParametersEventArgs)
            Dim customParameter = e.Parameters.FirstOrDefault(Function(p) p.Name = "parameterState")
            If customParameter IsNot Nothing Then
                ' Actual value used when retrieving data from the data source.
                customParameter.Value = "Nevada"
            End If
        End Sub
    End Class
End Namespace
