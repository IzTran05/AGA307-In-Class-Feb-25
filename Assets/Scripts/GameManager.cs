using UnityEngine;

public enum GameState{ Start, Playing, Paused, GameOver}
public enum Difficulty { Easy, Medium, Hard, Nightmare}

public class GameManager : MonoBehaviour
{
    public static GameManager instance;


    [SerializeField]public GameState gameState;
    public GameState GameState => gameState;
    [SerializeField]public Difficulty difficulty;
    [SerializeField] private int score;


    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);
    }

    public void AddScore(int _score)
    {
        score +=  _score;
        print("Score: " + score);
    }
}
