using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 public class LightDesapearenceTimer : MonoBehaviour
{
    [SerializeField] private float timeInitial=2;
    [SerializeField] private float timeActual;
    [SerializeField] public bool isTimerZero;

    void Start()
    {
        timeActual = timeInitial;
        isTimerZero = false;
    }

    
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        ComandToShortenLight();
    }
    private void LightTimer()
    {
        timeActual -= Time.deltaTime;
    }
    private void ComandToShortenLight()
    {
        LightTimer();
        if (timeActual<=0)
        {
            isTimerZero = true;
            timeActual = timeInitial;
        }
    }
}
