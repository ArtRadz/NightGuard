using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatsMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    private void FixedUpdate()
    {
        MovementControls();
    }
    public void MovementControls()
    {
        transform.position += transform.up * Time.deltaTime * speed;
    }
}
