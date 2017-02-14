using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    public string loadLevel;

    public void ChangeLevel()
    {
        SceneManager.LoadScene ("loadLevel", LoadSceneMode.Additive);
    }

    public void Exit()
    {
        Application.Quit();
        EditorApplication.isPlaying = false;
    }

}
