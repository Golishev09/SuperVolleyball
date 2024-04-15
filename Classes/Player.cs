using System.Collections.Generic;

namespace SuperVolleyball.Classes;

public class Player
{
    public string Player_Name_ID { get; set; }
    public int Player_Weight{ get; set; }
    public string Player_BirthDay { get; set; }
    public int Player_Height { get; set; }
    public List<Game> Games { get; set; }

    
    public Player(string name, int weight, string birthday, int height)
    {
        Player_Name_ID = name;
        Player_Weight = weight;
        Player_BirthDay = birthday;
        Player_Height = height;
        Games = new List<Game>();
    }

    public void AddGame(Game game)
    {
        Games.Add(game);
    }
    public string GetPlayer()
    {
        string playerIn =  $"{Player_Name_ID} {Player_Weight} {Player_BirthDay} {Player_Height}";
        foreach (Game games in Games)
        {
            playerIn += $"\n{games.GetGame()}";
        }

        return playerIn;

    }

}