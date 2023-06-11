using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ListenerBolos : MonoBehaviour
{
    public List<GameObject> listaBolos;
    List<GameObject> listaBolosOriginal;

    public AudioSource sonidoBolos;
    
    int puntos;

    private bool bolosCaidos;
    // Start is called before the first frame update
    void Start()
    {
        puntos = 0;
        listaBolosOriginal = new List<GameObject>(listaBolos);
        bolosCaidos = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(listaBolos.Count > 0)
        {
            foreach (GameObject bolo in listaBolos)
            {
                if (Mathf.Abs(bolo.transform.rotation.eulerAngles.z) > 50.0f || Mathf.Abs(bolo.transform.rotation.eulerAngles.y) > 50.0f)
                {
                    if (!bolosCaidos)
                    {
                        sonidoBolos.Play();
                        bolosCaidos = true;
                    }
                    puntos++;
                    GetComponent<TextMeshProUGUI>().text = puntos.ToString();
                    listaBolos.Remove(bolo);
                }
            }
        }
        else
        {
            GetComponent<TextMeshProUGUI>().text = "¡PLENO!";
        }
    }
    
    public void ResetPuntos()
    {
        bolosCaidos = false;
        puntos = 0;
        GetComponent<TextMeshProUGUI>().text = puntos.ToString();
        listaBolos = new List<GameObject>(listaBolosOriginal);
    }
}
