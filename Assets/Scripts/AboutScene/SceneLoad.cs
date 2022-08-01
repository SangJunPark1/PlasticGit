using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoad : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;       
            int nextSceneIndex = currentSceneIndex + 1;                             
            if (nextSceneIndex == SceneManager.sceneCountInBuildSettings)           
            {
                nextSceneIndex = 0;                                                 
            }
            SceneManager.LoadScene(nextSceneIndex);                                 
        }
    }
}
