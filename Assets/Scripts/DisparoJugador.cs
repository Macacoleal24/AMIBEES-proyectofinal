using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class DisparoJugador : MonoBehaviour
{
    [SerializeField] private Transform contoladorDisparo;
    [SerializeField] private GameObject bala;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            //Disparar
            Disparar();
        }

    }

    private void Disparar()
    {
        Instantiate(bala, contoladorDisparo.position, contoladorDisparo.rotation);
    }
}
