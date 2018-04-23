Imports Microsoft.VisualBasic
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
Imports System.Windows.Navigation
Imports System.Windows.Shapes

Namespace DocumentPanel_Content
	''' <summary>
	''' Interaction logic for UserControl1.xaml
	''' </summary>
	Partial Public Class UserControl1
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
		End Sub

		Public Sub SetDataContext(ByVal context As Object)
			Me.DataContext = context
			headerText.Visibility = System.Windows.Visibility.Collapsed
		End Sub

	End Class

End Namespace
