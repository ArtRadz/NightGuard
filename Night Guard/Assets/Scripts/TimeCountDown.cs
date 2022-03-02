using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimeCountDown : MonoBehaviour
{
    [SerializeField] TMP_Text timerText;
    [SerializeField] private int hoursToTheEnd;
    [SerializeField] private float minutesToTheEnd;
    private int minutesToTheEndInInt;
    public bool hasTimeRanOut;
    private void FixedUpdate()
    {
        Timer();
        TimeRemainingToText(); 
        TimerEnd();
    }
    private void Timer()
    {
        minutesToTheEnd -= Time.deltaTime;
        if(minutesToTheEnd<=0)
        {
            --hoursToTheEnd;
            minutesToTheEnd = 59;
        }
    }
    public void TimeRemainingToText()
    {
        minutesToTheEndInInt = (int)minutesToTheEnd;
        if (minutesToTheEnd >= 10)
        {
            timerText.text = "0" + hoursToTheEnd.ToString() + ":" + minutesToTheEndInInt.ToString();
        }
        else
        {
            timerText.text = "0" + hoursToTheEnd.ToString() + ":" + "0" + minutesToTheEndInInt.ToString();
        }
    }
    private void TimerEnd()
    {
        if(hoursToTheEnd<0)
        {
            hasTimeRanOut = true;
        }

    }
}
