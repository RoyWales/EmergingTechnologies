using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class headTilt : MonoBehaviour
{
    public GameObject msgUI;

    public Manager man;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "MainCamera")
        {
            msgUI.SetActive(true);
            man.QuestionAnswered();
        }
    }
   
}


