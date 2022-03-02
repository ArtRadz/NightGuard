using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorchGathering : MonoBehaviour
{
    LightControll[] lightControll;
    [SerializeField]public int numberOfTorchesGathered = 0;

    void Start()
    {
        lightControll = GetComponentsInChildren<LightControll>();
    }
    private void Update()
    {
        TorchLighting();
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Torch")
        {
            Destroy(collision.gameObject);
                ++numberOfTorchesGathered;
        }
    }
    private void TorchLighting()
    {
        if (Input.GetKeyDown("f")&&numberOfTorchesGathered>0)
        {   
            for (int i = 0; i < lightControll.Length; i++)
            {
                lightControll[i].LightReset();
            }
            numberOfTorchesGathered -= 1;
        }
    }
}
