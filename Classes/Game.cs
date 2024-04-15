namespace SuperVolleyball.Classes;

public class Game
{
    public int Game_ID { get; set; }
    public string Game_Position { get; set; }
    public string Game_StartTime { get; set; }
    public string Game_Team { get; set; }
    
    public Game(int id, string position, string startTime, string team)
    {
        Game_ID = id;
        Game_Position = position;
        Game_StartTime = startTime;
        Game_Team = team;
    }
    public string GetGame()
    {
        return $"{Game_ID} {Game_Position} {Game_StartTime} {Game_Team}";
        
    }
}