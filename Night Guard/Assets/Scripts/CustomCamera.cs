using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomCamera : MonoBehaviour
{
    public Camera cameraObject;
    PlayerMovementControler player;
    [SerializeField] private float cameraStartingSize;
    [SerializeField] private float cameraMaxSize;
    [SerializeField] private float cameraSize;
    [SerializeField] private float cameraGrowthIndex;
    
    void Start()
    {
        cameraSize = cameraStartingSize;
        player = FindObjectOfType<PlayerMovementControler>();
       
    }

    // Update is called once per frame
    void Update()
    {
        FollowThePlayer();
    }
    private void FollowThePlayer()
    {
        transform.position = new Vector3(player.transform.position.x, player.transform.position.y, -10);
    }
}
