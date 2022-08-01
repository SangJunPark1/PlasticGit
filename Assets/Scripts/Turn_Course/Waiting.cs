using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waiting : MonoBehaviour
{
    public static bool wait;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Control1>().enabled = false;
        wait = false;
    }

    // Update is called once per frame
    void Update()
    {
        Invoke("WaitScript", 0f);
    }

    void WaitScript()
    {
        gameObject.GetComponent<Control1>().enabled = true;
        wait = true;
        Debug.Log("asdfasdf");
    }
}
