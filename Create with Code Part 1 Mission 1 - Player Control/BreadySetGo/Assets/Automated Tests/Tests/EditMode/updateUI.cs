using NUnit.Framework;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScriptEditModeTests
{
[Test]
    public void Start_SetsLifeCountToThree()
    {
        var obj = new GameObject();
        var score = obj.AddComponent<ScoreScript>();

        // Use reflection to call protected Start method
        var startMethod = typeof(ScoreScript).GetMethod("Start", 
            System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
        startMethod?.Invoke(score, null);

        Assert.AreEqual(3, score.lifeCount);
    }

[Test]
public void Update_UpdatesUIText()
{
    var obj = new GameObject();
    var score = obj.AddComponent<ScoreScript>();

    // Create UI text fields
    var spreadObj = new GameObject();
    var lifeObj = new GameObject();

    score.spreadText = spreadObj.AddComponent<Text>();
    score.lifeText = lifeObj.AddComponent<Text>();

    // Set values
    score.spreadCount = 5;
    score.lifeCount = 2;

    // Use reflection to call protected Update method
    var updateMethod = typeof(ScoreScript).GetMethod("Update", 
        System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
    updateMethod?.Invoke(score, null);

    Assert.AreEqual("Spread Count: 5/7", score.spreadText.text);
    Assert.AreEqual("Lives: 2", score.lifeText.text);
}}