using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public HandRaised HR;
    

    public Input Input;
    public bool buttonHeld = false;

    public GameObject noMsg;
    public GameObject yesMsg;
    public GameObject handMsg;

    public GameObject handAcceptedMsg;
    public GameObject handRaiseHitbox;
    public GameObject handRaiseGlow;

    public GameObject respondBoxes;
    public GameObject questionMsg;

    public bool handRaised = false;
    public bool acceptedHandRaised = false;
    public bool questionAsked = false;

    public void TeacherQuestionAsked()
    {
        questionAsked = true;

        questionMsg.SetActive(true);
        //respondBoxes.SetActive(true);
    }

    public void QuestionAnswered()
    {
        questionAsked = false;

        questionMsg.SetActive(false);
        //respondBoxes.SetActive(false);

    }

    public void AcceptHandRaise()
    {
        if (handRaised == true)
        {
            HR.Handtoggle = false; //sets hand raise to false
            handRaiseGlow.SetActive(true);
            handRaiseHitbox.SetActive(false);
            handMsg.SetActive(false);
            acceptedHandRaised = true;
            handRaised = false;
            handAcceptedMsg.SetActive(true);
        }
       
    }

    public void ResetAllMessages()
    {
        noMsg.SetActive(false);
        yesMsg.SetActive(false);
        handMsg.SetActive(false);
        handAcceptedMsg.SetActive(false);
        questionMsg.SetActive(false);

        handRaiseHitbox.SetActive(true);
        handRaiseGlow.SetActive(false);

        HR.Handtoggle = false; //sets hand raise to false
        acceptedHandRaised = false;
        questionAsked = false;
        handRaised = false;
    }

    public void Update()
    {
       
    }

}
