using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandRaised : MonoBehaviour
{
    public GameObject msgUI;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Hand")
        {
            msgUI.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Hand")
        {
            msgUI.SetActive(false);
        }
    }
}

