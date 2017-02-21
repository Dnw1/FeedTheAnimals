using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DisplayScore : MonoBehaviour
{
    private int Highscore;
    private int CurrentScore;

    [SerializeField] private Text _score;
    [SerializeField] private Text _highScore;

    void Start()
    {
        Highscore = Score.CurrentHighScore;
        CurrentScore = 0;
    }

    void Update()
    {
        Highscore = Score.CurrentHighScore;
        //if (_score.name == "Score")
        //{
        //_score.GU
        _score.text = "Score: " + CurrentScore;
        //}
       // if (_highScore.name == "HighScore")
       // {
            _highScore.text = "HighScore: " + Highscore;
       // }
        GameEnded();
        if (Input.GetMouseButtonDown(0))
        {
            CurrentScore += 1;
        }
    }

    void GameEnded()
    {
        if (CurrentScore > Highscore)
        {
            Score.GetScore = CurrentScore;
        }
    }
}
