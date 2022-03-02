using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaminaCalculator : MonoBehaviour
{
    [SerializeField] public float stamina = 100;
    [SerializeField] public bool canRun = true;
    [SerializeField] public bool isRunning = false;
    [SerializeField] private float staminaCountDown = .5f;
    [SerializeField] private float staminaCountUp = .3f;
    private void FixedUpdate()
    {
        RunningFlag();
        StaminaCountDown();
        StaminaCountUp();
    }
    private void RunningFlag()
    {
       if(stamina<25&&!isRunning||stamina<=0)
        {
            canRun = false;
        }
       else
        {
            canRun = true;
        }
    }
    private void StaminaCountDown()
    {
        if(isRunning&&stamina>0)
        {
            stamina -= staminaCountDown*Time.deltaTime;
        }
    }
    private void StaminaCountUp()
    {
        if (!isRunning && stamina < 100)
        {

            stamina += staminaCountUp*Time.deltaTime;

        }
    }
}
