using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ListenerFeria : MonoBehaviour
{
    public List<GameObject> listaObjetivos;
    List<GameObject> listaObjetivosOriginal;

    int puntos;
    // Start is called before the first frame update
    void Start()
    {
        puntos = 0;
        listaObjetivosOriginal = new List<GameObject>(listaObjetivos);
    }

    // Update is called once per frame
    void Update()
    {
        if(listaObjetivos.Count > 0)
        {
            foreach (GameObject objetivo in listaObjetivos)
            {
                if (objetivo.transform.position.y < 1.95f)
                {
                    puntos++;
                    GetComponent<TextMeshProUGUI>().text = puntos.ToString();
                    listaObjetivos.Remove(objetivo);
                }
            }
        }
    }

    public void ResetPuntos()
    {
        puntos = 0;
        GetComponent<TextMeshProUGUI>().text = puntos.ToString();
        listaObjetivos = new List<GameObject>(listaObjetivosOriginal);
    }
}