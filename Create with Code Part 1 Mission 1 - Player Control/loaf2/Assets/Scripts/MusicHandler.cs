using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicHandler : MonoBehaviour
{
    private static MusicHandler instance;
    void Awake(){
        if (instance == null){
            instance = this;
            DontDestroyOnLoad(this.gameObject); // Keep the object across scene loads
        }
        else{
            Destroy(gameObject); // Destroy duplicate music handler
        }
    }
}
