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
        bolo8.GetComponent<Rigidbody>().Sleep();
        bolo5.GetComponent<Rigidbody>().Sleep();
        bolo6.GetComponent<Rigidbody>().Sleep();
        bolo7.GetComponent<Rigidbody>().Sleep();
        bolo0.GetComponent<Rigidbody>().Sleep();
        bolo1.GetComponent<Rigidbody>().Sleep();
        bolo2.GetComponent<Rigidbody>().Sleep();
        bolo3.GetComponent<Rigidbody>().Sleep();
        bolo4.GetComponent<Rigidbody>().Sleep();

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

        bolo8.GetComponent<Rigidbody>().WakeUp();
        bolo5.GetComponent<Rigidbody>().WakeUp();
        bolo6.GetComponent<Rigidbody>().WakeUp();
        bolo7.GetComponent<Rigidbody>().WakeUp();
        bolo0.GetComponent<Rigidbody>().WakeUp();
        bolo1.GetComponent<Rigidbody>().WakeUp();
        bolo2.GetComponent<Rigidbody>().WakeUp();
        bolo3.GetComponent<Rigidbody>().WakeUp();
        bolo4.GetComponent<Rigidbody>().WakeUp();

        bolaBolos.GetComponent<Rigidbody>().velocity = Vector3.zero;
        bolaBolos.transform.position = new Vector3(-4.744f, 1.629f, 93.743f);
    }

    public void ResetFeria()
    {
        munecoFeria1.GetComponent<Rigidbody>().Sleep();
        munecoFeria2.GetComponent<Rigidbody>().Sleep();
        munecoFeria3.GetComponent<Rigidbody>().Sleep();
        munecoFeria4.GetComponent<Rigidbody>().Sleep();
        munecoFeria5.GetComponent<Rigidbody>().Sleep();

        munecoFeria3.transform.position = new Vector3(91.625f, 2.218f, -15.437f);
        munecoFeria5.transform.position = new Vector3(91.625f, 2.218f, -12.199f);
        munecoFeria4.transform.position = new Vector3(90.94f, 2.95f, -11.17f);
        munecoFeria2.transform.position = new Vector3(90.94f, 2.95f, -13.61f);
        munecoFeria1.transform.position = new Vector3(90.94f, 2.95f, -16.32f);
        bolaFeria3.transform.position = new Vector3(92.99f, 1.97f, -17.76f);
        bolaFeria2.transform.position = new Vector3(92.99f, 1.97f, -15.67f);
        bolaFeria1.transform.position = new Vector3(92.99f, 1.97f, -13.41f);
        bolaFeria4.transform.position = new Vector3(92.99f, 1.97f, -11.09f);
        bolaFeria5.transform.position = new Vector3(92.99f, 1.97f, -8.59f);

        munecoFeria1.transform.rotation = Quaternion.identity;
        munecoFeria2.transform.rotation = Quaternion.identity;
        munecoFeria3.transform.rotation = Quaternion.identity;
        munecoFeria4.transform.rotation = Quaternion.identity;
        munecoFeria5.transform.rotation = Quaternion.identity;

        munecoFeria1.GetComponent<Rigidbody>().WakeUp();
        munecoFeria2.GetComponent<Rigidbody>().WakeUp();
        munecoFeria3.GetComponent<Rigidbody>().WakeUp();
        munecoFeria4.GetComponent<Rigidbody>().WakeUp();
        munecoFeria5.GetComponent<Rigidbody>().WakeUp();

    }

}
