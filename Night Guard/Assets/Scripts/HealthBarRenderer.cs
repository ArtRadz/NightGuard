using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarRenderer : MonoBehaviour
{
    LifeCalculator hp;
    Slider slider;
    void Start()
    {
        hp = FindObjectOfType<LifeCalculator>();
        slider = GetComponent<Slider>();
    }

    private void FixedUpdate()
    {
        Rendering();
    }
    private void Rendering()
    {
        slider.value =hp.lifeHP;
       
    }
}
