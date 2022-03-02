using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GoldText : MonoBehaviour
{
    GoldGathering gold;
    [SerializeField] TMP_Text goldText;
    // Start is called before the first frame update
    void Start()
    {
        gold = FindObjectOfType<GoldGathering>(); 
    }

    // Update is called once per frame
    void Update()
    {
        GoldToText();
    }
    private void GoldToText()
    {
        goldText.text = gold.goldGathered.ToString() + "/" + gold.numberOfGold.ToString();
    }
}
