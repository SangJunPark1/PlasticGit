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
        // �ٷ� ���� ���������� �Ѿ�� ġƮŰ
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
            SceneManager.LoadScene(13);
            Scene_SortOrder.currentSceneIndex = 0;
        }
        else
        {
            
            SceneManager.LoadScene(Scene_SortOrder.SceneSort[Scene_SortOrder.currentSceneIndex]);    // 'nextSceneIndex' ��° ���� ����϶� 
            Scene_SortOrder.currentSceneIndex += 1;
        }

    }

}
