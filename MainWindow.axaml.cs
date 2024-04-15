using System;
using Avalonia.Controls;
using Avalonia.Interactivity;
using SuperVolleyball.ErrorWindows;
using SuperVolleyball.Windows;

namespace SuperVolleyball;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        Height = 150;
        Width = 300;
    }

    private void Login_Btn_Click(object? sender, RoutedEventArgs e)
    {
        string login = LoginTextBox.Text;
        string password = PasswordTextBox.Text;
        try
        {
            if (password == "1234560" && login == "Login"  )
            {
                TableWindow tableWin = new TableWindow();
                tableWin.Show();
                this.Close();
            }
            else
            {
                ErrorWindow errw = new ErrorWindow();
                errw.Show();
            }
        }
        catch (Exception ex)
        {
            {
                ErrorWindow errorWin = new ErrorWindow();
                errorWin.Show();
            }
        }
    }

    private void Rb1_Checked(object? sender, RoutedEventArgs e)
    {
        int a = 1;
    }

    private void Rb2_Checked(object? sender, RoutedEventArgs e)
    {
        int a = 0;
    }
}