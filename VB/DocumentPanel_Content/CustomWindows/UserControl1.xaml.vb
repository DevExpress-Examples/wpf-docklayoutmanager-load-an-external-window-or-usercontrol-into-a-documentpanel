Imports System.Windows
Imports System.Windows.Controls

Namespace DocumentPanel_Content

    ''' <summary>
    ''' Interaction logic for UserControl1.xaml
    ''' </summary>
    Public Partial Class UserControl1
        Inherits UserControl

        Public Sub New()
            Me.InitializeComponent()
        End Sub

        Public Sub SetDataContext(ByVal context As Object)
            DataContext = context
            Me.headerText.Visibility = Visibility.Collapsed
        End Sub
    End Class
End Namespace
