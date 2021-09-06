<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128643691/21.1.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2410)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/DocumentPanel_Content/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/DocumentPanel_Content/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/DocumentPanel_Content/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/DocumentPanel_Content/MainWindow.xaml.vb))
<!-- default file list end -->
# How to: Load an External Window or UserControl into a DocumentPanel


<p>You can define a Window, Page or UserControl in external XAML files and then, with DXDocking, load their contents into <a href="https://documentation.devexpress.com/#WPF/clsDevExpressXpfDockingDocumentPaneltopic">DocumentPanel</a> objects.</p>
<p>This example demonstrates how to load an external Window and UserControl into DocumentPanels.</p>
<p>In the example three approaches are demonstrated:<br><br></p>
<p>1) The contents of MyWindow.xaml is loaded into a DocumentPanel at design time (in XAML) via the <a href="https://documentation.devexpress.com/#WPF/DevExpressXpfDockingContentItem_Contenttopic">DocumentPanel.Content</a> property. The Content property accepts a Uri object, which must refer to a XAML file defining a Window, Page or UserControl.</p>


```xaml
<dxdo:DocumentPanel x:Name="docPanel2" Caption="Panel 2" Content="{dxdo:RelativeUri UriString=CustomWindows\\MyWindow.xaml}"/>
```


<p><br>2) The DocumentPanel.Content property is set with a Uri object at runtime:</p>


```cs
docPanel1.Content = new Uri(@"CustomWindows\MyWindow1.xaml", UriKind.Relative);
```


<p> </p>
<p>3) The <a href="https://documentation.devexpress.com/#WPF/DevExpressXpfDockingDockLayoutManager_DockControllertopic">DockLayoutManager.DockController</a>.<a href="https://documentation.devexpress.com/#WPF/DevExpressXpfDockingDockControllerBase_AddDocumentPaneltopic">AddDocumentPanel</a> method creates a new DocumentPanel object and loads the contents of an external XAML file into the created panel. </p>


```cs
panel1 = dockLayoutManager1.DockController.AddDocumentPanel(documentGroup1,

    new Uri(@"CustomWindows\UserControl1.xaml", UriKind.Relative));

panel1.Caption = "Document " + (ctr++).ToString();
```


<br>
<p>In the example, the XAML file defines a UserControl object. The loaded UserControl is accessed via the DocumentPanel's Control property and then a method on the UserControl is invoked.</p>


```cs
//...

(panel1.Control as UserControl1).SetDataContext(imageInfo);
```


<br>
<p>You can see this in action by clicking the "Set DataContext for UserControl" button in the example.</p>

<br/>


