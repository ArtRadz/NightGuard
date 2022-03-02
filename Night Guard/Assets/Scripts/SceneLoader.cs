using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneLoader : MonoBehaviour
{
    public void LoadNextScene()
    {
        int CurrentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        if (CurrentSceneIndex < 2)
        {
            SceneManager.LoadScene(CurrentSceneIndex + 1);
        }
        else if (CurrentSceneIndex == 2)
        {
            Application.Quit();
        }
    }
    public void LoadLoseScene()
    {
        SceneManager.LoadScene("GameOver");
    }
    public void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void LoadWinScene()
    {
        SceneManager.LoadScene("VictoryScreen");
    }
}
