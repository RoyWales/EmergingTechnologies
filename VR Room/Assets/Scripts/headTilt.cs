using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class headTilt : MonoBehaviour
{
    public GameObject msgUI;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "MainCamera")
        {
            msgUI.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "MainCamera")
        {
            msgUI.SetActive(false);
        }
    }
}


