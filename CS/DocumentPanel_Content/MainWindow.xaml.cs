using System;
using System.Windows;
using System.Windows.Media.Imaging;
using DevExpress.Xpf.Docking;

namespace DocumentPanel_Content {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }
        void ActivateItem(BaseLayoutItem item) {
            dockLayoutManager1.LayoutController.Activate(item);
        }
        //Load MyWindow1.xaml into docPanel1
        private void btnSetContent_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e) {
            ActivateItem(docPanel1);
            docPanel1.Content = new Uri(@"CustomWindows\MyWindow1.xaml", UriKind.Relative);
        }
        DocumentPanel panel1 = null;
        int ctr = 1;
        private void btnAddDockPanel_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e) {
            panel1 = dockLayoutManager1.DockController.AddDocumentPanel(documentGroup1,
                new Uri(@"CustomWindows\UserControl1.xaml", UriKind.Relative));
            panel1.Caption = "Document " + (ctr++).ToString();

            DocumentPanel.SetMDISize(panel1, new Size(400, 300));
            DocumentPanel.SetMDILocation(panel1, new Point(200, 200));
            ActivateItem(panel1);
        }
        void btnSetDataContext_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e) {
            if(panel1 == null) return;
            Uri uri = new Uri("/Images/IMG_1391.jpg", UriKind.Relative);
            ImageInfo imageInfo = new ImageInfo();
            imageInfo.Source = new BitmapImage(uri);
            imageInfo.Description = uri.ToString();
            //Invoke a method on the loaded UserControl
            (panel1.Control as UserControl1).SetDataContext(imageInfo);
            ActivateItem(panel1);
        }
    }
}
