using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    public static bool First_finish = false;
    void Start()
    {
        First_finish = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            First_finish = true;
            // Debug.Log("gkgkgkgk");
        }
    }
}
