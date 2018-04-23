using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace DocumentPanel_Content {
    /// <summary>
    /// Interaction logic for MyWindow.xaml
    /// </summary>
    public partial class MyWindow : Window {
        public MyWindow() {
            InitializeComponent();
        }


        void setMargin(int leftOffset, int topOffset) {
            btnTarget.Margin = new Thickness(btnTarget.Margin.Left + leftOffset, btnTarget.Margin.Top+ topOffset, btnTarget.Margin.Right, btnTarget.Margin.Bottom );

        }

        private void btnLeft_Click(object sender, RoutedEventArgs e) {
            setMargin(-10, 0);
        }

        private void btnUp_Click(object sender, RoutedEventArgs e) {
            setMargin(0, -10);
        }

        private void btnRight_Click(object sender, RoutedEventArgs e) {
            setMargin(10, 0);
        }

        private void btnDown_Click(object sender, RoutedEventArgs e) {
            setMargin(0, 10);
        }

    }
        
}
