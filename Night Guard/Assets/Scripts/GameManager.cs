using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    WinZone win;
    LifeCalculator hp;
    SceneLoader loader;
    TimeCountDown time;
   
    void Start()
    {
        win = FindObjectOfType<WinZone>();
        hp = FindObjectOfType<LifeCalculator>();
        loader = FindObjectOfType<SceneLoader>();
        time = FindObjectOfType<TimeCountDown>();
    }

    
    void Update()
    {
        GameOver();
        Victory();
    }
    private void GameOver()
    {
        if(hp.lifeHP<=0||time.hasTimeRanOut)
        {
            loader.LoadLoseScene();
        }
    }
    private void Victory()
    {
        if (win.hasWon)
        {
            loader.LoadWinScene();
        }
    }
}
