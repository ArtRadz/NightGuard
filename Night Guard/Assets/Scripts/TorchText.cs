using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TorchText : MonoBehaviour
{
    TorchGathering torch;
    [SerializeField] TMP_Text torchText;
    // Start is called before the first frame update
    void Start()
    {
        torch = FindObjectOfType<TorchGathering>();
    }

    // Update is called once per frame
    void Update()
    {
        GoldToText();
    }
    private void GoldToText()
    {
        torchText.text = torch.numberOfTorchesGathered.ToString();
    }
}
