using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public string LevelName;

    public ScoreScript sc;

    // this function loads the Game Over scene
    public void LoadLevel()
    {   
        
        SceneManager.LoadScene(LevelName);
        
    }
}
