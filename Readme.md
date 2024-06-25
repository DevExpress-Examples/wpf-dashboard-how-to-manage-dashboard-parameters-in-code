<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/134282817/18.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T830592)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [MyViewModel.cs](./cs/WPF_Dashboard_CustomParameters/ViewModels/MyViewModel.cs)
* [MyDashboardView.xaml.cs](./cs/WPF_Dashboard_CustomParameters/Views/MyDashboardView.xaml.cs)
* [MyDashboardView.xaml](./cs/WPF_Dashboard_CustomParameters/Views/MyDashboardView.xaml)

<!-- default file list end -->

# Dashboard for WPF - How to Manage Dashboard Parameters in Code 

This example shows how to override an initial or user-defined <a href="https://docs.devexpress.com/Dashboard/400012/building-the-designer-and-viewer-applications/wpf-viewer/manage-dashboard-parameters">dashboard parameter</a> value by changing it in the <a href="https://docs.devexpress.com/Dashboard/DevExpress.DashboardWpf.DashboardControl.CustomParameters">DashboardControl.CustomParameters</a> event handler. The effective parameter value is hidden from the end-user, and if you set the [DashboardParameter.Visible](https://docs.devexpress.com/Dashboard/DevExpress.DashboardCommon.DashboardParameter.Visible) property to false, the parameter itself will also be hidden.

To accomplish this task, a parameter named <strong>parameterState</strong> is added to the dashboard. It has a default value and a list of values to show in a look-up editor. A <a href="https://docs.devexpress.com/Dashboard/400012/building-the-designer-and-viewer-applications/wpf-viewer/manage-dashboard-parameters">Dashboard Parameters dialog</a> displays the values and allows the end-user to select a parameter value in the list.<br>However, by handling the <a href="https://docs.devexpress.com/Dashboard/DevExpress.DashboardWpf.DashboardControl.CustomParameters">DashboardControl.CustomParameters</a> event, we can validate the parameter value and ignore the value provided by the end-user. To accomplish this, source data is filtered using a <strong>parameterState </strong>parameter.The value of this parameter is changed at runtime by handling the <a href="https://docs.devexpress.com/Dashboard/DevExpress.DashboardWpf.DashboardControl.CustomParameters">DashboardControl.CustomParameters</a> event which is raised before the dashboard sends a query to a database. Thus, only the value passed in the <a href="https://docs.devexpress.com/Dashboard/DevExpress.DashboardWpf.DashboardControl.CustomParameters">DashboardControl.CustomParameters</a> event is in effect.<br>

![](https://github.com/DevExpress-Examples/wpf-dashboard-how-to-manage-dashboard-parameters-in-code/blob/18.1.3%2B/images/wpf-dashboard-how-to-manage-dashboard-parameters-in-code.png)

## Documentation

- [Manage Dashboard Parameters](https://docs.devexpress.com/Dashboard/400012/wpf-viewer/manage-dashboard-parameters)
- [DashboardControl.CustomParameters](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWpf.DashboardControl.CustomParameters)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-dashboard-how-to-manage-dashboard-parameters-in-code&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-dashboard-how-to-manage-dashboard-parameters-in-code&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
