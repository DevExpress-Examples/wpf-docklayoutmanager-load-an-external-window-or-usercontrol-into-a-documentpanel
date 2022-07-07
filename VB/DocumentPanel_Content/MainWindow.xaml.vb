Imports System
Imports System.Windows
Imports System.Windows.Media.Imaging
Imports DevExpress.Xpf.Docking

Namespace DocumentPanel_Content

    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
        End Sub

        Private Sub ActivateItem(ByVal item As BaseLayoutItem)
            Me.dockLayoutManager1.LayoutController.Activate(item)
        End Sub

        'Load MyWindow1.xaml into docPanel1
        Private Sub btnSetContent_ItemClick(ByVal sender As Object, ByVal e As DevExpress.Xpf.Bars.ItemClickEventArgs)
            Me.ActivateItem(Me.docPanel1)
            Me.docPanel1.Content = New Uri("CustomWindows\MyWindow1.xaml", UriKind.Relative)
        End Sub

        Private panel1 As DocumentPanel = Nothing

        Private ctr As Integer = 1

        Private Sub btnAddDockPanel_ItemClick(ByVal sender As Object, ByVal e As DevExpress.Xpf.Bars.ItemClickEventArgs)
            panel1 = Me.dockLayoutManager1.DockController.AddDocumentPanel(Me.documentGroup1, New Uri("CustomWindows\UserControl1.xaml", UriKind.Relative))
            panel1.Caption = "Document " & Math.Min(Threading.Interlocked.Increment(ctr), ctr - 1).ToString()
            Call DocumentPanel.SetMDISize(panel1, New Size(400, 300))
            Call DocumentPanel.SetMDILocation(panel1, New Point(200, 200))
            ActivateItem(panel1)
        End Sub

        Private Sub btnSetDataContext_ItemClick(ByVal sender As Object, ByVal e As DevExpress.Xpf.Bars.ItemClickEventArgs)
            If panel1 Is Nothing Then Return
            Dim uri As Uri = New Uri("/Images/IMG_1391.jpg", UriKind.Relative)
            Dim imageInfo As ImageInfo = New ImageInfo()
            imageInfo.Source = New BitmapImage(uri)
            imageInfo.Description = uri.ToString()
            'Invoke a method on the loaded UserControl
            TryCast(panel1.Control, UserControl1).SetDataContext(imageInfo)
            ActivateItem(panel1)
        End Sub
    End Class
End Namespace
