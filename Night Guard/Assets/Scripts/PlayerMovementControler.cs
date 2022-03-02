using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementControler : MonoBehaviour
{
    [SerializeField] private float speed = 5;
    [SerializeField] private float rotationalAngle = 5;
    [SerializeField] private float speedActual;
    [SerializeField] private float runingSpeed;
    [SerializeField] public bool isWalking = false;
    StaminaCalculator stamina;
    void Start()
    {
        stamina = FindObjectOfType<StaminaCalculator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        WalkingControls();
        RotattionControls();
    }
    public void WalkingControls()
    {
        if (Input.GetKey("s") || Input.GetKey("a") || Input.GetKey("d"))
        {
            speedActual = speed / 2;
            stamina.isRunning = false;
        }
        else if (Input.GetKey(KeyCode.LeftShift)&& Input.GetKey("w")&&stamina.canRun)
        {
            speedActual = runingSpeed;
            stamina.isRunning = true;
        }
        else if (Input.GetKey("w"))
        {
            speedActual = speed;
            stamina.isRunning = false;
        }
        transform.Translate(
                     Input.GetAxis("Horizontal") * speedActual * Time.deltaTime,
                     Input.GetAxis("Vertical") * speedActual * Time.deltaTime,
                     0);
        isWalking = true;
    }

    public void RotattionControls()
    {
        if (Input.GetKey("q"))
        {
            transform.Rotate(new Vector3(0, 0, rotationalAngle));
        }
        else if (Input.GetKey("e"))
        {
            transform.Rotate(new Vector3(0, 0, -rotationalAngle));
        }
    }
}
