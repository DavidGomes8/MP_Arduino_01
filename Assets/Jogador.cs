using ArdJoystick;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogador : MonoBehaviour
{
    public ArdController ardController;

    private void Start()
    {
    }

    private void Update()
    {
        if (ardController.GetKeyDown(ArdKeyCode.BUTTON_LEFT))
        {
            
        }
        else if (ardController.GetKeyUp(ArdKeyCode.BUTTON_LEFT))
        {
            Debug.Log("Botão A pressionado (down)");
        }
        else if (ardController.GetKeyDown(ArdKeyCode.BUTTON_LEFT))
        {

        }
        if (ardController.GetKeyDown(ArdKeyCode.BUTTON_DOWN))
        {
            Debug.Log("Botão A pressionado (down)");
        }
        if (ardController.GetKeyDown(ArdKeyCode.BUTTON_UP))
        {
            Debug.Log("Botão A pressionado (down)");
        }
        if (ardController.GetKeyDown(ArdKeyCode.BUTTON_RIGHT))
        {
            Debug.Log("Botão A pressionado (down)");
        }
        if (ardController.GetKeyDown(ArdKeyCode.BUTTON_START))
        {
            Debug.Log("Botão A pressionado (down)");
        }
        if (ardController.GetKeyDown(ArdKeyCode.BUTTON_SELECT))
        {
            Debug.Log("Botão A pressionado (down)");
        }
        if (ardController.GetKeyDown(ArdKeyCode.BUTTON_Y))
        {
            Debug.Log("Botão A pressionado (down)");
        }
        if (ardController.GetKeyDown(ArdKeyCode.BUTTON_B))
        {
            Debug.Log("Botão A pressionado (down)");
        }
        if (ardController.GetKeyDown(ArdKeyCode.BUTTON_X))
        {
            Debug.Log("Botão A pressionado (down)");
        }
        if (ardController.GetKeyDown(ArdKeyCode.BUTTON_A))
        {
            Debug.Log("Botão A pressionado (down)");
        }
    }
}