Imports System.Collections.ObjectModel
Imports DevExpress.Xpf.Docking
Imports System.Windows.Media

Namespace WpfApplication

    Public Class MainViewModel

        Public Sub New()
            ChildViews.Add(New DocumentViewModel("Document1", "/Images/change.png"))
            ChildViews.Add(New DocumentViewModel("Document2", "/Images/create.png"))
            ChildViews.Add(New DocumentViewModel("Document2", "/Images/new-16x16.png"))
            ChildViews.Add(New PanelViewModel(Colors.Red))
            ChildViews.Add(New PanelViewModel(Colors.Blue))
            ChildViews.Add(New PanelViewModel(Colors.Green))
        End Sub

        Private _Children As ObservableCollection(Of Object) = New ObservableCollection(Of Object)()

        Public Property ChildViews As ObservableCollection(Of Object)
            Get
                Return _Children
            End Get

            Set(ByVal value As ObservableCollection(Of Object))
                _Children = value
            End Set
        End Property
    End Class
End Namespace
