using System.Collections;  
using System.Collections.Generic;  
using UnityEngine;  
using UnityEngine.SceneManagement; 

public class SceneChange : MonoBehaviour
{
    AudioSource audioData;
    public void ChangeScene(string sceneName) {
        audioData = GetComponent<AudioSource>();
        audioData.Play(0);
        SceneManager.LoadScene(sceneName);  
    }
}
