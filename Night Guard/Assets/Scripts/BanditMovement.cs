using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BanditMovement : MonoBehaviour
{
    [SerializeField] private bool isRunning = false;
    [SerializeField] private float speed = 5;
    [SerializeField] private float runingSpeed = 7;
    [SerializeField] public float rotationalAngle;
    [SerializeField] public float initialRotationTimer;
    [SerializeField] private float rotationTimer = 30;
    [SerializeField] private float runingTimer = 5;
    [SerializeField] private float runingTimerConstant = 5;
    [SerializeField] GameObject target;

    private void Start()
    {
        
    }
    void Update()
    {

    }
    private void FixedUpdate()
    {
        WalkingControls();
        TimedRotation();
        RuningTimer();
    }
    public void WalkingControls()
    {
        if (isRunning == false)
        {
            transform.position += transform.up * Time.deltaTime * speed;
        }
        else if(isRunning==true)
        {
            transform.position += transform.up * Time.deltaTime * runingSpeed;
        }
    }
    public void RotationAngleRandomizer()
    {
        rotationalAngle = Random.Range(0, 180);
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            RotationAngleRandomizer();
            transform.Rotate(new Vector3(0, 0, rotationalAngle));
            rotationTimer = initialRotationTimer;
        }
    }
    private void TimedRotation()
    {
        rotationTimer-=Time.deltaTime;
        if (rotationTimer <= 0)
        {
            RotationAngleRandomizer();
            transform.Rotate(new Vector3(0, 0, rotationalAngle));
            rotationTimer = initialRotationTimer;
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.tag=="Player")
        {
            isRunning = true;
            /* RotationAngleRandomizer();
              transform.Rotate(new Vector3(0, 0, rotationalAngle));
              rotationTimer = initialRotationTimer;*/
            transform.up = collision.transform.position - transform.position;
        }
    }
    private void RuningTimer() 
    {
        if(isRunning==true)
        {
            runingTimer -= Time.deltaTime;
            if (runingTimer<=0)
            {
                isRunning = false;
                runingTimer = runingTimerConstant;
            }
        }
    }
}
