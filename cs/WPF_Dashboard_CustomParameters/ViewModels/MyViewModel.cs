using System;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using System.Linq;
using DevExpress.DashboardCommon;
using System.Collections.Generic;

namespace WPF_Dashboard_CustomParameters.ViewModels
{
    [POCOViewModel]
    public class MyViewModel
    {
        protected MyViewModel() {
            //Dashboard = new SampleDashboard(); 
            Dashboard dashboard = new Dashboard();
            dashboard.LoadFromXml("Data\\SampleDashboard.xml");
            AddParameter(dashboard);
            ModifyFilter(dashboard);
            Dashboard = dashboard;
        }
        public virtual DevExpress.DashboardCommon.Dashboard Dashboard { get; set; }
        private void ModifyFilter(Dashboard dashboard)
        {
            dashboard.DataSources[0].Filter = "[State] In (?parameterState)";
        }
        private void AddParameter(Dashboard dashboard)
        {
            DashboardParameter myDashboardParameter = new DashboardParameter();
            StaticListLookUpSettings staticListLookUpSettings1 = new StaticListLookUpSettings();
            myDashboardParameter.AllowMultiselect = true;
            // Parameter values displayed in the look-up editor.
            staticListLookUpSettings1.Values = new string[] { "Alabama", "Ohio", "Utah" };
            myDashboardParameter.LookUpSettings = staticListLookUpSettings1;
            myDashboardParameter.Name = "parameterState";
            myDashboardParameter.Type = typeof(string);
            // Default parameter value.
            myDashboardParameter.Value = new List<string> { "Ohio", "Utah" };
            dashboard.Parameters.Add(myDashboardParameter);
        }
        public void OnCustomParameters(DevExpress.DashboardCommon.CustomParametersEventArgs e)
        {
            var customParameter = e.Parameters.FirstOrDefault(p => p.Name == "parameterState");
            if (customParameter != null)
            {
                // Actual value used when retrieving data from the data source.
                customParameter.Value = "Nevada";
            }
        }
    }
}