using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandRaised : MonoBehaviour
{
    public GameObject msgUI;
    public bool Handtoggle = false;
    public Manager Man;
    public ButtonPress but;

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Hand" && but.buttonPressed && !Handtoggle)
        {
            Handtoggle = true;
            Man.handRaised = true; // setting hand rasied to true
            msgUI.SetActive(true);
            but.Toggle2();
        }
        else if (other.tag == "Hand" && but.buttonPressed)
        {
            Handtoggle = false;
            Man.handRaised = false; // setting hand rasied to true
            msgUI.SetActive(false);
            but.Toggle2();
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

