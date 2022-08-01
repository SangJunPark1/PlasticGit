using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crash_Point1 : MonoBehaviour
{
    public GameObject Signal_Ready;
    public GameObject Signal_Steady;
    public GameObject Signal_Acceleration;

    [SerializeField] public string WhatSignal;

    void Start()
    {
        Signal_Ready.SetActive(false);
        Signal_Steady.SetActive(false);
        Signal_Acceleration.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (WhatSignal == "Ready")
            {
                Signal_Ready.SetActive(true);
                Signal_Steady.SetActive(false);
                Signal_Acceleration.SetActive(false);
            }

            if (WhatSignal == "Steady")
            {
                Signal_Ready.SetActive(false);
                Signal_Steady.SetActive(true);
                Signal_Acceleration.SetActive(false);
            }

            if (WhatSignal == "Acceleration")
            {
                Signal_Ready.SetActive(false);
                Signal_Steady.SetActive(false);
                Signal_Acceleration.SetActive(true);
            }
        }
    }
}
