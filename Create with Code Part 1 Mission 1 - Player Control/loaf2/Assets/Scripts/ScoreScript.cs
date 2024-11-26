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

    void Start()
    {
        lifeCount = 3;
    }

    // Update is called once per frame
    void Update()
    {
        spreadText.text = "Spread Count: " + spreadCount.ToString();
        lifeText.text = "Lives: " + lifeCount.ToString();
    }
}
