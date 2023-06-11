using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectarColisionFeria : MonoBehaviour
{
    public AudioSource golpeFeria;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Objetivo"))
        {
            golpeFeria.Play();
        }
    }
}
