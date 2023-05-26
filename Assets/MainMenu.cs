using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject menu;

    public GameObject bolo0;
    public GameObject bolo1;
    public GameObject bolo2;
    public GameObject bolo3;
    public GameObject bolo4;
    public GameObject bolo5;
    public GameObject bolo6;
    public GameObject bolo7;
    public GameObject bolo8;
    public GameObject bolaBolos;

    public GameObject munecoFeria1;
    public GameObject munecoFeria2;
    public GameObject munecoFeria3;
    public GameObject munecoFeria4;
    public GameObject munecoFeria5;
    public GameObject bolaFeria1;
    public GameObject bolaFeria2;
    public GameObject bolaFeria3;
    public GameObject bolaFeria4;
    public GameObject bolaFeria5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Salir()
    {
        Application.Quit();
    }

    public void ResetBolos()
    {
        bolo8.transform.position = new Vector3(-2.669f, 1.175f, 103.929f);
        bolo5.transform.position = new Vector3(-3.229f, 1.175f, 104.595f);
        bolo6.transform.position = new Vector3(-2.669f, 1.175f, 104.591f);
        bolo7.transform.position = new Vector3(-2.173f, 1.175f, 104.591f);
        bolo0.transform.position = new Vector3(-3.76f, 1.175f, 105.29f);
        bolo1.transform.position = new Vector3(-3.2f, 1.175f, 105.29f);
        bolo2.transform.position = new Vector3(-2.669f, 1.175f, 105.29f);
        bolo3.transform.position = new Vector3(-2.184f, 1.175f, 105.29f);
        bolo4.transform.position = new Vector3(-1.702f, 1.175f, 105.29f);

        bolo8.transform.rotation = Quaternion.identity;
        bolo5.transform.rotation = Quaternion.identity;
        bolo6.transform.rotation = Quaternion.identity;
        bolo7.transform.rotation = Quaternion.identity;
        bolo0.transform.rotation = Quaternion.identity;
        bolo1.transform.rotation = Quaternion.identity;
        bolo2.transform.rotation = Quaternion.identity;
        bolo3.transform.rotation = Quaternion.identity;
        bolo4.transform.rotation = Quaternion.identity;

        bolaBolos.transform.position = new Vector3(-4.744f, 1.629f, 93.743f);
    }

    public void ResetFeria()
    {

    }

}
