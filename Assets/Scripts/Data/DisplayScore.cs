using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DisplayScore : MonoBehaviour
{
    private int Highscore; //Highscore you have ingame.
    private int CurrentScore; //Your current score for right answers.

    [SerializeField] private Text _score; //Holds the text for the current score.
    [SerializeField] private Text _highScore; //Holds the text for the highscore.

    void Start()
    {
        Highscore = Score.CurrentHighScore; //Set highscore to saved highscore.
        CurrentScore = 0; //Set current score to 0.
    }
    
    void Update()
    {
        Highscore = Score.CurrentHighScore; //Update highscore incase current score get's above previous highscore.

        _score.text = "Score: " + CurrentScore; //Show ingame current score.
        _highScore.text = "HighScore: " + Highscore; //Show ingame the highscore.

        GameEnded(); //If the game has ended save the current highscore. Need to make it a gameobject.find probably or something less hardcoded.
    }

    void GameEnded()
    {
        if (CurrentScore > Highscore) //If the currentscore is higher than the highscore ingame.
        {
            Score.GetScore = CurrentScore; //Set the highscore of other script to current score and save it
        }
    }
}
