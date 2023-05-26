using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DropDown : MonoBehaviour
{
    public GameObject jugador;
    public GameObject menu;

    public void HandleInputData(int val)
    {
        if (val == 0)
        {
            jugador.transform.position = new Vector3(0.0f, 20.0f, 0.0f);
            menu.transform.position = new Vector3(2.667f, 0.0f, 15.046f);
        }
        else if(val == 1)
        {
            jugador.transform.position = new Vector3(-2.49f, 20.0f, 88.75f);
            menu.transform.position = new Vector3(0.0f, 0.0f, 100.0f);
        }
        else if(val == 2)
        {
            jugador.transform.position = new Vector3(97.3f, 20.0f, -14.1f);
            menu.transform.position = new Vector3(100.0f, 0.0f, 0.0f);
        }
    }
}
