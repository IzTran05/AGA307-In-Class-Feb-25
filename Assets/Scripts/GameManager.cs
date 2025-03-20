using TMPro.EditorUtilities;
using UnityEngine;

public enum GameState{ Start, Playing, Paused, GameOver}
public enum Difficulty { Easy, Medium, Hard, Nightmare}

public class GameManager : Singleton<GameManager>
{


    [SerializeField]public GameState gameState;
    public GameState GameState => gameState;
    [SerializeField]public Difficulty difficulty;
    [SerializeField] private int score;


  

    public void AddScore(int _score)
    {
        score +=  _score;
        _UI.UpdateScore(score);
    }
}
