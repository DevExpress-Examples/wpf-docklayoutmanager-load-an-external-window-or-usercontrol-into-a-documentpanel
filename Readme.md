<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128643691/22.2.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2410)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# WPF Dock Layout Manager - Load an External Window or UserControl into a DocumentPanel

You can define a Window, Page, or UserControl in external XAML files and load their contents into [DocumentPanel](https://docs.devexpress.com/WPF/DevExpress.Xpf.Docking.DockLayoutManager.DocumentPanel) objects.

This example loads an external Window and UserControl into DocumentPanels in three ways:

1. Use the [DocumentPanel.Content](https://docs.devexpress.com/WPF/DevExpress.Xpf.Docking.ContentItem.Content) inherited property to load the content of _MyWindow.xaml_ into a [DocumentPanel](https://docs.devexpress.com/WPF/DevExpress.Xpf.Docking.DockLayoutManager.DocumentPanel) at design time (in XAML). The **Content** property accepts an [Uri](https://docs.microsoft.com/en-us/dotnet/api/system.uri) object that is linked to a XAML file and defines a Window, Page, or UserControl.


    ```xaml
    <dxdo:DocumentPanel x:Name="docPanel2" Caption="Panel 2" Content="{dxdo:RelativeUri UriString=CustomWindows\\MyWindow.xaml}"/>
    ```

2. The [DocumentPanel.Content](https://docs.devexpress.com/WPF/DevExpress.Xpf.Docking.ContentItem.Content) property is set with a [Uri](https://docs.microsoft.com/en-us/dotnet/api/system.uri) object at runtime:</p>

    ```cs
    docPanel1.Content = new Uri(@"CustomWindows\MyWindow1.xaml", UriKind.Relative);
    ```

3. Call the [DockLayoutManager.DockController](https://docs.devexpress.com/WPF/DevExpress.Xpf.Docking.DockLayoutManager.DockController)'s [AddPanel](https://docs.devexpress.com/WPF/DevExpress.Xpf.Docking.DockControllerBase.AddDocumentPanel.overloads) method to create a new [DocumentPanel](https://docs.devexpress.com/WPF/DevExpress.Xpf.Docking.DockLayoutManager.DocumentPanel) object and load the contents of an external XAML file into the created panel.

    ```cs
    panel1 = dockLayoutManager1.DockController.AddDocumentPanel(documentGroup1,

        new Uri(@"CustomWindows\UserControl1.xaml", UriKind.Relative));

    panel1.Caption = "Document " + (ctr++).ToString();
    ```

In the example, the XAML file defines a UserControl object. The example's code uses the [DocumentPanel](https://docs.devexpress.com/WPF/DevExpress.Xpf.Docking.DockLayoutManager.DocumentPanel)'s [Control](https://docs.devexpress.com/WPF/DevExpress.Xpf.Docking.LayoutPanel.Control) inherited property to access the loaded UserControl, and then invokes the UserControl's method:

```cs
//...

(panel1.Control as UserControl1).SetDataContext(imageInfo);
```

In the example, you can the _Set DataContext for UserControl_ button to see this in action.

![image](https://github.com/DevExpress-Examples/wpf-docklayoutmanager-load-an-external-window-or-usercontrol-into-a-documentpanel/assets/65009440/4d10f9ef-c02c-4619-98e2-903da24fb107)

## Files to Review

* [MainWindow.xaml](./CS/DocumentPanel_Content/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/DocumentPanel_Content/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/DocumentPanel_Content/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/DocumentPanel_Content/MainWindow.xaml.vb))

## Documentation

- [Dock UI Items](https://docs.devexpress.com/WPF/7209/controls-and-libraries/layout-management/dock-windows/dock-items)
- [DocumentPanel](https://docs.devexpress.com/WPF/DevExpress.Xpf.Docking.DocumentPanel)
- [DockLayoutManager.DockController](https://docs.devexpress.com/WPF/DevExpress.Xpf.Docking.DockLayoutManager.DockController)
- [DockController.AddPanel](https://docs.devexpress.com/WPF/DevExpress.Xpf.Docking.DockControllerBase.AddDocumentPanel.overloads)

## More Examples

- [WPF Dock Layout Manager - Create a Simple Layout of Dock Panes](https://github.com/DevExpress-Examples/how-to-create-a-simple-layout-of-dock-panes-e1600)
- [WPF Dock Layout Manager - Create a Complex Layout of Dock Panels](https://github.com/DevExpress-Examples/how-to-create-a-complex-layout-of-dock-panels-e1663)
- [WPF Dock Layout Manager - Сreate a DocumentGroup with Two Tabs](https://github.com/DevExpress-Examples/how-to-create-a-documentgroup-with-two-tabs-e1670)
- [WPF Dock Layout Manager - Create Tabbed and Document Groups](https://github.com/DevExpress-Examples/how-to-create-a-tabbedgroup-and-documentgroup-groups-e1656)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-docklayoutmanager-load-an-external-window-or-usercontrol-into-a-documentpanel&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-docklayoutmanager-load-an-external-window-or-usercontrol-into-a-documentpanel&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
