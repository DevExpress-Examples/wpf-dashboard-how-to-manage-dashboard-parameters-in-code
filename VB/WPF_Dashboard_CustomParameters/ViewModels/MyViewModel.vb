Imports DevExpress.Mvvm.DataAnnotations
Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.POCO
Imports DevExpress.DashboardCommon
Imports System.Collections.Generic

Namespace WPF_Dashboard_CustomParameters.ViewModels

    <POCOViewModel>
    Public Class MyViewModel

        Protected Sub New()
            'Dashboard = new SampleDashboard(); 
            Dim dashboard As Dashboard = New Dashboard()
            dashboard.LoadFromXml("Data\SampleDashboard.xml")
            Me.AddParameter(dashboard)
            Me.ModifyFilter(dashboard)
            Me.Dashboard = dashboard
        End Sub

        Public Overridable Property Dashboard As DevExpress.DashboardCommon.Dashboard

        Private Sub ModifyFilter(ByVal dashboard As Dashboard)
            dashboard.DataSources(0).Filter = "[State] In (?parameterState)"
        End Sub

        Private Sub AddParameter(ByVal dashboard As Dashboard)
            Dim myDashboardParameter As DashboardParameter = New DashboardParameter()
            Dim staticListLookUpSettings1 As StaticListLookUpSettings = New StaticListLookUpSettings()
            myDashboardParameter.AllowMultiselect = True
            ' Parameter values displayed in the look-up editor.
            staticListLookUpSettings1.Values = New String() {"Alabama", "Ohio", "Utah"}
            myDashboardParameter.LookUpSettings = staticListLookUpSettings1
            myDashboardParameter.Name = "parameterState"
            myDashboardParameter.Type = GetType(String)
            ' Default parameter value.
            myDashboardParameter.Value = New List(Of String) From {"Ohio", "Utah"}
            dashboard.Parameters.Add(myDashboardParameter)
        End Sub

        Public Sub OnCustomParameters(ByVal e As DevExpress.DashboardCommon.CustomParametersEventArgs)
            Dim customParameter = e.Parameters.FirstOrDefault(Function(p) p.Name Is "parameterState")
            If customParameter IsNot Nothing Then
                ' Actual value used when retrieving data from the data source.
                customParameter.Value = "Nevada"
            End If
        End Sub
    End Class
End Namespace
