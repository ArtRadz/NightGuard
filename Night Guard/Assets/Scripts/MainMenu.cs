using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    SceneLoader loader;
    public GameObject mainMenu;
   // Levels level;
    
    void Start()
    {
        loader = FindObjectOfType<SceneLoader>();
       // level = FindObjectOfType<Levels>();
       // level.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartButton()
    {
        SceneManager.LoadScene("Tutorial");
    }
    /*private void OpenLevelSubMenu()
    {
        level.SetActive(true);
    }*/
    public void QuitGame()
    {
        Application.Quit();
    }

}
