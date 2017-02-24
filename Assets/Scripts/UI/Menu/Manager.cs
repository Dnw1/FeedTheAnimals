using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    public string loadLevel; //Hold name of scene to load.

    public void ChangeLevel()
    {
        SceneManager.LoadScene ("loadLevel", LoadSceneMode.Additive);
    } //load the scene of same string as in loadLevel.

    public void Exit()
    {
        Application.Quit();
        EditorApplication.isPlaying = false;
        //If activated exits game and also stops playing in unity play.
    }

}
