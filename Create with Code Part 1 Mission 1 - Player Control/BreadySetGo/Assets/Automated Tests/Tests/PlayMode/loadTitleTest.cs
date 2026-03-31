using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.TestTools;

public class TitlePlayModeTests
{
    [UnityTest]
    public IEnumerator LoadLevel_LoadsCorrectScene()
    {
        // Create a GameObject and add StartGame component
        var obj = new GameObject("Loader");
        var startGame = obj.AddComponent<StartGame>();

        // Set the scene name
        startGame.LevelName = "Title";

        // Load the scene
        startGame.LoadLevel();

        // Wait one frame for the scene to load
        yield return null;

        // Assert the active scene is the one we expected
        Assert.AreEqual("Title", SceneManager.GetActiveScene().name);
    }
}