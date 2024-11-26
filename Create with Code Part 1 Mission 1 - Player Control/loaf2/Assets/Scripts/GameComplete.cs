using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameComplete : MonoBehaviour
{
    public string LevelName;

    // this function loads the Game Over scene
    public void LoadLevel()
    {   
        
        SceneManager.LoadScene(LevelName);
        
    }
}