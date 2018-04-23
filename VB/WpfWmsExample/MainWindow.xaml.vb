Imports System.Windows
Imports DevExpress.Xpf.Map

Namespace WpfWmsExample
    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Partial Public Class MainWindow
        Inherits Window

        Public Sub New()
            InitializeComponent()
        End Sub
        Private Sub OnResponseCapabilities(ByVal sender As Object, ByVal e As CapabilitiesResponsedEventArgs)
            listBox.ItemsSource = e.Layers
        End Sub
    End Class
End Namespace
