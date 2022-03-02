using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StaminaBar : MonoBehaviour
{
    StaminaCalculator staminaC;
    Slider slider;
    void Start()
    {
        staminaC = FindObjectOfType<StaminaCalculator>();
        slider = GetComponent<Slider>();
    }

    private void FixedUpdate()
    {
        Rendering();
    }
    private void Rendering()
    {
        slider.value = staminaC.stamina;
    }
}
