using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public string LevelName;

    // this function loads the Start Game scene
    public void LoadLevel()
    {
        SceneManager.LoadScene(LevelName);
    }
}
