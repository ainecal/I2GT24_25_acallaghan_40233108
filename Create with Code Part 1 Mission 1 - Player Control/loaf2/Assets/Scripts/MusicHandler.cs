using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicHandler : MonoBehaviour
{
    // this function makes sure that the music applied to every scene
    void Awake(){
        DontDestroyOnLoad(this);
    }

}
