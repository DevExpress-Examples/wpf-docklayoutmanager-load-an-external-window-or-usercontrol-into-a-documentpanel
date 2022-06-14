Imports System.Windows
Imports System.Windows.Controls

Namespace DocumentPanel_Content

    ''' <summary>
    ''' Interaction logic for MyWindow.xaml
    ''' </summary>
    Public Partial Class MyWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
        End Sub

        Private Sub setMargin(ByVal leftOffset As Integer, ByVal topOffset As Integer)
            Me.btnTarget.Margin = New Thickness(Me.btnTarget.Margin.Left + leftOffset, Me.btnTarget.Margin.Top + topOffset, Me.btnTarget.Margin.Right, Me.btnTarget.Margin.Bottom)
        End Sub

        Private Sub btnLeft_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            setMargin(-10, 0)
        End Sub

        Private Sub btnUp_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            setMargin(0, -10)
        End Sub

        Private Sub btnRight_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            setMargin(10, 0)
        End Sub

        Private Sub btnDown_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            setMargin(0, 10)
        End Sub
    End Class
End Namespace
