using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestColourSwap : MonoBehaviour
{
    public Material baseMat;
    public Material changeMat;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Hand")
        {
            GetComponent<Renderer>().material = changeMat;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Hand")
        {
            GetComponent<Renderer>().material = baseMat;
        }
    }
}
