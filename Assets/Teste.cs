using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teste : MonoBehaviour
{
    public ArdJoystick.ArdController ardController;

    private void Start()
    {
    }

    private void Update()
    {
        if (ardController.GetKeyDown(ArdJoystick.ArdKeyCode.BUTTON_A))
        {
        }
    }
}