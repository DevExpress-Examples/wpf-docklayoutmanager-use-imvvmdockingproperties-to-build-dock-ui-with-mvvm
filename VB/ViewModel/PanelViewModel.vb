Imports System
Imports DevExpress.Xpf.Docking
Imports System.Windows.Media

Namespace WpfApplication

    Public Class PanelViewModel
        Implements IMVVMDockingProperties

        Public Sub New(ByVal c As Color)
            _Color = New SolidColorBrush(c)
        End Sub

        Private Property TargetName As String Implements IMVVMDockingProperties.TargetName
            Get
                Return "DockPanels"
            End Get

            Set(ByVal value As String)
                Throw New NotImplementedException()
            End Set
        End Property

        ' Fields...
        Private _Color As SolidColorBrush

        Public Property ColorBrush As SolidColorBrush
            Get
                Return _Color
            End Get

            Set(ByVal value As SolidColorBrush)
                _Color = value
            End Set
        End Property
    End Class
End Namespace
