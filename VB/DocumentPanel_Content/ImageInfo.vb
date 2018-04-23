Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows.Media

Namespace DocumentPanel_Content
	Friend Class ImageInfo
		Private privateSource As ImageSource
		Public Property Source() As ImageSource
			Get
				Return privateSource
			End Get
			Set(ByVal value As ImageSource)
				privateSource = value
			End Set
		End Property
		Private privateDescription As String
		Public Property Description() As String
			Get
				Return privateDescription
			End Get
			Set(ByVal value As String)
				privateDescription = value
			End Set
		End Property
	End Class
End Namespace
