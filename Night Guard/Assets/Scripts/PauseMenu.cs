using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    private bool isPaussed;
    SceneLoader loader;
    CustomCursor customCursor;
    
    void Start()
    {
        customCursor = FindObjectOfType<CustomCursor>();
        pauseMenu.SetActive(false);
        customCursor.DeactivatingSelf();
        loader = FindObjectOfType<SceneLoader>();
    }

    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(isPaussed)
            {
                ResumeGame();
            }
            if(!isPaussed)
            {
                PauseGame();
            }
        }
    }
    public void PauseGame()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        customCursor.ActivatingSelf();
        isPaussed = true;
    }
    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        customCursor.DeactivatingSelf();
        isPaussed = false;
    }
    public void GoToMainMenu()
    {
        Time.timeScale = 1f;
        loader.LoadMainMenu();
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
