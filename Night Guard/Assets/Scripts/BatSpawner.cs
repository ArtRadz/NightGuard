using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatSpawner : MonoBehaviour
{
    private float randomizer;
    private float positionOffsetToPlayer;
    [SerializeField] GameObject playerObject;
    [SerializeField] private float positionOffsetToPlayerMax = 8;
    [SerializeField] private float positionOffsetToPlayerMin = -8;
    [SerializeField] private float timerMinValue = 3;
    [SerializeField] private float timerMaxValue = 10;
    [SerializeField] private float timerRandomizer;

    private void Start()
    {
        timerRandomizer = Random.Range(timerMaxValue, timerMinValue);
    }
    private void FixedUpdate()
    {
        Spawn();
    }
    private void SpawnDeastanceRandomizer()
    {
        randomizer = Random.Range(0, 10);
        if(randomizer<5)
        {
            positionOffsetToPlayer = positionOffsetToPlayerMax;
        }
        else
        {
            positionOffsetToPlayer = positionOffsetToPlayerMin;
        }
    }
    private void PositionController()
    {
        SpawnDeastanceRandomizer();
        transform.position = new Vector3
             (playerObject.transform.position.x + positionOffsetToPlayer,
             playerObject.transform.position.y + positionOffsetToPlayer,
             -2);
    }
    private void SpawnTimer()
    {
        timerRandomizer -= Time.deltaTime;
    }
    private void Spawn()
    {
        SpawnTimer();
        if(timerRandomizer<=0)
        {
            
            PositionController();
            timerRandomizer = Random.Range(timerMaxValue, timerMinValue);
        }
    }
}
