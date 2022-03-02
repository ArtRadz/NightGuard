using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinZone : MonoBehaviour
{ 
    GoldGathering gold;
    public bool hasWon;
    private void Start()
    {
        gold = FindObjectOfType<GoldGathering>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag=="Player"&& gold.isGoldOnScene==false)
        {
            hasWon = true;
            Debug.Log(hasWon + " In Collider Collision Detected");

        }
    }
}
