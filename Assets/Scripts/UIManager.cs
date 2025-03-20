using UnityEngine;
using TMPro;
using System.Xml.Serialization;
using UnityEngine.TextCore.Text;

public class UIManager : Singleton<UIManager>
{
    [SerializeField] private TMP_Text scoreText;
    [SerializeField] private TMP_Text enemyCountText;

    private void Start()
    {
        ResetUI();
    }

    private void ResetUI()
    {
        UpdateEnemyCount(0);
        UpdateScore(0);
    }
    public void UpdateScore(int _score)
    {
        scoreText.text = "Score: " + _score;
    }
    public void UpdateEnemyCount(int _enemyCount)
    {
        //if (_enemyCount >= 3)
        //enemyCountText.color = Color.red;
        // else

        //enemyCountText.color = Color.white;


        string textColour = _enemyCount >= 3 ? "<color=red" : "<color=white>";
        //enemyCountText.color = _enemyCount >= 3 ? Color.red : Color.white;
        enemyCountText.text = "Enemy count: " + textColour + _enemyCount + "</color";
    }
}
