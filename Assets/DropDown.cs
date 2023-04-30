using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DropDown : MonoBehaviour
{
    public GameObject jugador;

    public void HandleInputData(int val)
    {
        switch (val)
        {
            case 0:
                jugador.transform.position = new Vector3(0.0f, 20.0f, 0.0f);
                break;
            case 1:
                jugador.transform.position = new Vector3(0.0f, 20.0f, 100.0f);
                break;
            case 2:
                jugador.transform.position = new Vector3(100.0f, 20.0f, 0.0f);
                break;
            default:
                jugador.transform.position = new Vector3(0.0f, 100.0f, 0.0f);
                break;
        }
    }
}
