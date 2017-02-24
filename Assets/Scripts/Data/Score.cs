using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class Score : MonoBehaviour
{
    public static int CurrentHighScore;
    public int oldHighScore;
    public static int GetScore;
    public int newHighScore;


    void Start()
    {
        PlayerPrefs.GetInt("highscore"); //Get saved highscore if any.
        oldHighScore = PlayerPrefs.GetInt("highscore"); //Set oldHighScore to the found highscore.
        CurrentHighScore = oldHighScore; //Make the CurrentHighScore ingame same as oldHighScore.
    }

    void Update()
    {
        StoreHighscore(); //Keep checking till game ends.
    }

    void StoreHighscore()
    {
        newHighScore = GetScore; //Get ingame score and set newHighScore to it.
        if (newHighScore > oldHighScore) //Compare the 2.
        {
            PlayerPrefs.SetInt("highscore", newHighScore);
            PlayerPrefs.Save(); //If it is higher save it as the new highscore.
        }
        if (newHighScore < oldHighScore) //Compare the 2.
        {
            PlayerPrefs.SetInt("highscore", oldHighScore);
            PlayerPrefs.Save(); //If it is lower save the old highscore again.
        }
    }
}
