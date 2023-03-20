using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class ButtonPress : MonoBehaviour
{
    public bool buttonPressed = false;
    public InputActionReference toggleRefference = null;
    public GameObject toggled;

    public void Awake()
    {
        toggleRefference.action.started += Toggle;
        
    }
    public void OnDestroy()
    {
        toggleRefference.action.performed -= Toggle;
        //toggleRefference.action.started -= Toggle;
    }


    public void Toggle(InputAction.CallbackContext context)
    {
        buttonPressed = !buttonPressed;
        toggled.SetActive(buttonPressed);
    }

    public void Toggle2()
    {
        buttonPressed = !buttonPressed;
        toggled.SetActive(buttonPressed);
    }
}
