using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialTriggers : MonoBehaviour
{
    GameObject activeCollision;
    private bool isColided;
    private bool isIteratingMultipleTimes;
    [SerializeField] private int curentMessageDisplaying;
    [SerializeField] private int maximalMessageDisplaying;
    [SerializeField] GameObject[] tutorialText;
    void Start()
    {
        TutorialMessageSetActiveFalseOnStart();
    }
    void Update()
    {
        if(isColided)
        {
            IteratingThroughMessages(); 
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Tutorial1")
        {
            activeCollision = collision.gameObject;
            Time.timeScale = 0f;
            curentMessageDisplaying = 0;
            isIteratingMultipleTimes = false;
            isColided = true;
            maximalMessageDisplaying = 0;
        }
        else if (collision.gameObject.tag == "Tutorial2")
        {
            activeCollision = collision.gameObject; 
            Time.timeScale = 0f;
            curentMessageDisplaying = 1;
            maximalMessageDisplaying = 1;
            isColided = true;
            isIteratingMultipleTimes = false;
        }
        else if (collision.gameObject.tag == "Tutorial3")
        {
            activeCollision = collision.gameObject; 
            Time.timeScale = 0f;
            curentMessageDisplaying = 2;
            isIteratingMultipleTimes = true;
            isColided = true;
            maximalMessageDisplaying = 9;


        }
    }
   
    private void IteratingThroughMessages()
    {
        DisplayMessage();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            tutorialText[curentMessageDisplaying].SetActive(false);
            if(!isIteratingMultipleTimes)
            {
                Time.timeScale = 1f;
                tutorialText[curentMessageDisplaying].SetActive(false);
                isColided = false;
                Destroy(activeCollision);
            }
            else if(isIteratingMultipleTimes)
            {
                curentMessageDisplaying++;
                if(curentMessageDisplaying== maximalMessageDisplaying)
                {
                    Time.timeScale = 1f;
                    tutorialText[curentMessageDisplaying-1].SetActive(false);
                    isColided = false;
                    Destroy(activeCollision);
                }
            }
        } 
    }
    
    private void TutorialMessageSetActiveFalseOnStart()
    {
        for (int i=0;i<tutorialText.Length;i++)
        {
            tutorialText[i].SetActive(false);
        }
    }
    private void DisplayMessage()
    {
        tutorialText[curentMessageDisplaying].SetActive(true);
    }
}
