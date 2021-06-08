# WPF Dashboard - How to Manage Dashboard Parameters in Code 


This example shows how to override an initial or user-defined <a href="https://docs.devexpress.com/Dashboard/400012/building-the-designer-and-viewer-applications/wpf-viewer/manage-dashboard-parameters">dashboard parameter</a> value by changing it in the <a href="https://docs.devexpress.com/Dashboard/DevExpress.DashboardWpf.DashboardControl.CustomParameters">DashboardControl.CustomParameters</a> event handler. The effective parameter value is hidden from the end-user, and if you set the [DashboardParameter.Visible](https://docs.devexpress.com/Dashboard/DevExpress.DashboardCommon.DashboardParameter.Visible) property to false, the parameter itself will also be hidden.

To accomplish this task, a parameter named <strong>parameterState</strong> is added to the dashboard. It has a default value and a list of values to show in a look-up editor. A <a href="https://docs.devexpress.com/Dashboard/400012/building-the-designer-and-viewer-applications/wpf-viewer/manage-dashboard-parameters">Dashboard Parameters dialog</a> displays the values and allows the end-user to select a parameter value in the list.<br>However, by handling the <a href="https://docs.devexpress.com/Dashboard/DevExpress.DashboardWpf.DashboardControl.CustomParameters">DashboardControl.CustomParameters</a> event, we can validate the parameter value and ignore the value provided by the end-user. To accomplish this, source data is filtered using a <strong>parameterState </strong>parameter.The value of this parameter is changed at runtime by handling the <a href="https://docs.devexpress.com/Dashboard/DevExpress.DashboardWpf.DashboardControl.CustomParameters">DashboardControl.CustomParameters</a> event which is raised before the dashboard sends a query to a database. Thus, only the value passed in the <a href="https://docs.devexpress.com/Dashboard/DevExpress.DashboardWpf.DashboardControl.CustomParameters">DashboardControl.CustomParameters</a> event is in effect.<br>

![](https://github.com/DevExpress-Examples/wpf-dashboard-how-to-manage-dashboard-parameters-in-code/blob/18.1.3%2B/images/wpf-dashboard-how-to-manage-dashboard-parameters-in-code.png)

## Documentation

- [Manage Dashboard Parameters](https://docs.devexpress.com/Dashboard/400012/wpf-viewer/manage-dashboard-parameters)
- [DashboardControl.CustomParameters](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWpf.DashboardControl.CustomParameters)
