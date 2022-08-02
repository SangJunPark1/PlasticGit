using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class Scene_SortOrder : MonoBehaviour
{

    [SerializeField]
    private Toggle Course_Toggle;  // 토글
    [SerializeField] 
    private Text Course_Text;  // 씬 등장 순서를 보여줄 텍스트

    [SerializeField]
    int SceneBuildNum;  // 자신에 맞는 씬 번호

    public static int currentSceneIndex ;

    public static List<int> SceneSort = new List<int>();  // 씬 번호가 순차적으로 담기는 배열
    static int[] SceneBuildNum_List = new int[] { 100, 100, 100, 100, 100, 100, 100, 100, 100, 100, 100};  // 씬 등장 순서
    // 예를 들면 1번씬-2등, 2번씬-3등, 3번씬-1등 으로 체크를 했다면
    // SceneSort = {3,1,2}
    // SceneBuildNum_List = {2,3,1}

    private void Start()
    {
        currentSceneIndex = 0;
    }

    void Update()
    {
        // 디버그로 로그 찍히는 거 확인용
        if (Input.GetKeyDown(KeyCode.P))
        {
            for (int i = 0; i < SceneSort.Count; i++)
            {
                Debug.Log(i + " :: " + SceneSort[i]);
            }

            for (int i = 0; i < SceneBuildNum_List.Length; i++)
            {
                Debug.Log(i + " ->-> " + SceneBuildNum_List[i]);
            }
        }

        // 반복문을 돌려서 SceneBuildNum_List에 순서를 담아줌
        for (int i = 0; i < SceneSort.Count; i++)
        {
            for (int j = 0; j < 11; j++)
            {
                if (SceneSort[i] == j+1)
                {
                    SceneBuildNum_List[j] = i;

                }
            }
        }


        // toggle이 체크되어있다면, SceneBuildNum_List 배열값(씬 등장 순서)를 텍스트로 띄움
        if (Course_Toggle.isOn == true)
        {
            Course_Text.text = SceneBuildNum_List[SceneBuildNum-1].ToString();
        }

        // toggle이 체크 되어있지 않다면, 텍스트로 "-"를 띄움
        if (Course_Toggle.isOn == false)
        {
            Course_Text.text = "-";
        }

    }


    public void OnChangeToggle()
    {
        // toggle이 체크되어있다면, SceneSort에 해당 씬 번호를 넣어줌
        if (Course_Toggle.isOn == true) 
        { 
            SceneSort.Add(SceneBuildNum); 
        }

        // toggle이 체크 되어있지 않다면, SceneSort에 해당 씬 번호를 삭제
        if (Course_Toggle.isOn == false) 
        {   SceneSort.Remove(SceneBuildNum); 
        }
    }


}
