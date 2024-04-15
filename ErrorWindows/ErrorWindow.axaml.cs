using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace SuperVolleyball.ErrorWindows;

public partial class ErrorWindow : Window
{
    public ErrorWindow()
    {
        InitializeComponent();
        Height = 110;
        Width = 310;
    }

    private void Button_CLose_On_Click(object? sender, RoutedEventArgs e)
    {
        this.Close();
    }
}