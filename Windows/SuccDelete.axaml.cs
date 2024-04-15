using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace SuperVolleyball.Windows;

public partial class SuccDelete : Window
{
    public SuccDelete()
    {
        InitializeComponent();
        Width = 220;
        Height = 100;
    }

    private void Button_CLose_On_Click(object? sender, RoutedEventArgs e)
    {
        this.Close();    
    }
}