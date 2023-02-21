using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandRaised : MonoBehaviour
{
    public GameObject msgUI;
    public bool Handtoggle = false;
    public Manager Man;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Hand" )
        {
            Handtoggle = !Handtoggle;
            Man.handRaised = Handtoggle; // setting hand rasied to true
            msgUI.SetActive(Handtoggle);
        }
    }

    public void Update()
    {
        if(Man.acceptedHandRaised == true)
        {
            msgUI.SetActive(false);
            Man.acceptedHandRaised = false;
        }
    }
}

