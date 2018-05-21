using System.Linq;
using System.Windows.Controls;

namespace WPF_Dashboard_CustomParameters.Views
{
    /// <summary>
    /// Interaction logic for MyDashboardView.xaml
    /// </summary>
    public partial class MyDashboardView : UserControl
    {
        public MyDashboardView()
        {
            InitializeComponent();
        }

        private void DashboardControl_CustomParameters(object sender, DevExpress.DashboardCommon.CustomParametersEventArgs e)
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
