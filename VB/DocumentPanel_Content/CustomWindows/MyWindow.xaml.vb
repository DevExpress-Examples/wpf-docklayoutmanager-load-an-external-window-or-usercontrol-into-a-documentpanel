Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Shapes

Namespace DocumentPanel_Content
	''' <summary>
	''' Interaction logic for MyWindow.xaml
	''' </summary>
	Partial Public Class MyWindow
		Inherits Window

		Public Sub New()
			InitializeComponent()
		End Sub


		Private Sub setMargin(ByVal leftOffset As Integer, ByVal topOffset As Integer)
			btnTarget.Margin = New Thickness(btnTarget.Margin.Left + leftOffset, btnTarget.Margin.Top+ topOffset, btnTarget.Margin.Right, btnTarget.Margin.Bottom)

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
