using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldGathering : MonoBehaviour
{
    public int numberOfGold;
    public int goldGathered=0;
    [SerializeField] AudioSource goldSound;
    public bool isGoldOnScene=true;
    private void Start()
    {
        numberOfGold = GameObject.FindGameObjectsWithTag( "Gold" ).Length;
    }
    private void Update()
    {
        HasWon();
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Gold")
        {
            Destroy(collision.gameObject);
            ++goldGathered;
            goldSound.Play();
           
        }
    }
    private void HasWon()
    {
        if (numberOfGold == goldGathered)
        {
            isGoldOnScene = false;
            //Debug.Log(isGoldOnScene + "inGoldGathering");
        }
    }
}
