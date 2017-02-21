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
        PlayerPrefs.GetInt("highscore");
        oldHighScore = PlayerPrefs.GetInt("highscore");
        CurrentHighScore = oldHighScore;
    }

    void Update()
    {
        StoreHighscore();
    }

    void StoreHighscore()
    {
        newHighScore = GetScore;
        if (newHighScore > oldHighScore)
        {
            PlayerPrefs.SetInt("highscore", newHighScore);
            PlayerPrefs.Save();
        }
        if (newHighScore < oldHighScore)
        {
            PlayerPrefs.SetInt("highscore", oldHighScore);
            PlayerPrefs.Save();
        }
    }
}
