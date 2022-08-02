using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoad : MonoBehaviour
{
    private void Start()
    {

        for (int i = 0; i < Scene_SortOrder.SceneSort.Count; i++)
        {
            Debug.Log(i + " :: " + Scene_SortOrder.SceneSort[i]);
        }
    }

    private void Update()
    {
        // 바로 다음 스테이지로 넘어가는 치트키
        if (Input.GetKeyDown(KeyCode.Q))
        {
            LoadNextLevel();
        }
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {

            LoadNextLevel();
        }
    }

    public static void LoadNextLevel()                                                       
    {

        if (Scene_SortOrder.currentSceneIndex >= Scene_SortOrder.SceneSort.Count)
        {
            SceneManager.LoadScene(12);
            Scene_SortOrder.currentSceneIndex = 0;
        }
        else
        {
            
            SceneManager.LoadScene(Scene_SortOrder.SceneSort[Scene_SortOrder.currentSceneIndex]);    // 'nextSceneIndex' 번째 씬을 출력하라 
            Scene_SortOrder.currentSceneIndex += 1;
        }

    }

}
