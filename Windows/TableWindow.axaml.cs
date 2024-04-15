using System;
using System.Collections.Generic;
using System.Linq;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using SuperVolleyball.Classes;
using SuperVolleyball.ErrorWindows;

namespace SuperVolleyball.Windows;

public partial class TableWindow : Window
{
    private List<Player> PlayersList { get; set; }
    private List<Game> GamesList { get; set; }

    private Player player1 = new Player("Василес",50 ,"10.03.2004" ,185);
    private Player player2 = new Player("Валентин",83 ,"25.08.2003" ,192);
    private Player player3 = new Player("Кровцов",113 ,"03.12.2002" ,168);
    

    private Game game1 = new Game(1, "Attack", "10:15", "The Red Coats");
    private Game game2 = new Game(2, "Defend", "13:00", "The Fishers");
    private Game game3 = new Game(3, "Attack", "18:30", "The Tough Shells");

    
    public TableWindow()
    {
        PlayersList = new List<Player>();
        GamesList = new List<Game>();
        
        InitializeComponent();
        TableDataGrid.ItemsSource = PlayersList;
        ShowTable();
        Width = 743;
        Height = 450;
    }
    private void ShowTable()
    {
            PlayersList.Add(player1);
            player1.AddGame(game1);
            PlayersList.Add(player2);
            player2.AddGame(game2);
            PlayersList.Add(player3);
            player3.AddGame(game3);
        
        TableDataGrid.ItemsSource = PlayersList;
    }
    private void Teach_search_OnTextChangedOnTextChanged(object? sender, TextChangedEventArgs e)
    {
        try
        {
            var Search = PlayersList;
            Search = Search.Where(x => x.Player_Name_ID.Contains(searchPlayers.Text.ToLower())).ToList();
            TableDataGrid.ItemsSource = Search;
        }
        catch (Exception exception)
        {
            ErrorWindow errorWin = new ErrorWindow();
            errorWin.Show();
        }
    }
    private void Back_OnClick(object? sender, RoutedEventArgs e)
    {
        MainWindow mainWin = new MainWindow();
        mainWin.Show();
        this.Close();
    }
    //Соритровка
    private void SortPlayers_OnSelectionChanged(object? sender, SelectionChangedEventArgs e)
    {
        try
        {
            var Sort1 = PlayersList;
            var Sort2 = GamesList;
            switch (SortPlayers.SelectedIndex)
            {
                case 0:
                    Sort1 = Sort1.OrderBy(x => x.Player_Name_ID).ToList();
                    break;
                //Сортирует по дням, а не по годам, т.к это String а не Date или Boolean
                case 1:
                    Sort1 = Sort1.OrderBy(x => x.Player_BirthDay).ToList();
                    break;
                case 2:
                    Sort2 = Sort2.OrderBy(x => x.Game_Position).ToList();
                    break;
            }
            TableDataGrid.ItemsSource = Sort1;
            TableDataGrid.ItemsSource = Sort2;
        }
        catch (Exception exception)
        {
            ErrorWindow errorWin = new ErrorWindow();
            errorWin.Show();
        }
    }

    private void Delete_OnClick(object? sender, RoutedEventArgs e)
    {
        
        var playerDel = TableDataGrid.SelectedItem as Player;
        if (playerDel != null)
        {
            PlayersList.Remove(playerDel);
            TableDataGrid.ItemsSource = null;
            TableDataGrid.ItemsSource = PlayersList;
        }
        SuccDelete sucDelWin = new SuccDelete();
        sucDelWin.Show();
    }
}