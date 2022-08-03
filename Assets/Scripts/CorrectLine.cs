using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorrectLine : MonoBehaviour
{
    bool isRoad;
    bool isRoad1;
    [SerializeField] public GameObject emergency; // 경로이탈 텍스트

    void Start()
    {
        isRoad = true;
        isRoad1 = true;
        // isRoad1 = true;
    }

    void Update()
    {
        if(isRoad == true && isRoad1 == true)
        {
            emergency.SetActive(false);
            Debug.Log("On the Road");
        }
        else
        {
            emergency.SetActive(true);
            Debug.Log("XXXXXXXX");
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "EmptyBox")
        {
            isRoad = false;
        }
        if (other.gameObject.tag == "EmptyBox1")
        {
            isRoad1 = false;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "EmptyBox")
        {
            isRoad = true;
        }
        if (other.gameObject.tag == "EmptyBox1")
        {
            isRoad1 = true;
        }
    }

}
