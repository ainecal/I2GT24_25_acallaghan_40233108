using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{

    public int spreadCount;
    public Text spreadText;

    public int lifeCount;

    public Text lifeText;

    // Declaring that the Life Count starts off at 3
    void Start()
    {
        lifeCount = 3;
    }

    // this function updates the UI with the Life Count and Spread Count
    void Update()
    {
        spreadText.text = "Spread Count: " + spreadCount.ToString();
        lifeText.text = "Lives: " + lifeCount.ToString();
    }
}
