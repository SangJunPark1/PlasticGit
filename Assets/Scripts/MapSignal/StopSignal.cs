using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopSignal : MonoBehaviour
{
    public GameObject stopText;
    public GameObject Signal_Steady;

    void Start()
    {
        stopText.SetActive(false);
        Signal_Steady.SetActive(false);
    }

     private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            StartCoroutine(ShowStop());
        }
    }

    IEnumerator ShowStop()
    {
        Signal_Steady.SetActive(false);
        int count = 0;
        while (count < 3)
        {
            stopText.SetActive(true);
            yield return new WaitForSeconds(0.5f);
            stopText.SetActive(false);
            yield return new WaitForSeconds(0.5f);
            count++;
        }
        Signal_Steady.SetActive(true);
    }
}
