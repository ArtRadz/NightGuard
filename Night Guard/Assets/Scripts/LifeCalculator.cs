using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCalculator : MonoBehaviour
{
    [SerializeField] public float lifeHP=100;
    [SerializeField] public float damageTakenOnCollision = 25;

    private void OnCollisionStay2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="Enemy")
        {
            lifeHP -= damageTakenOnCollision;
        }
    }
}
