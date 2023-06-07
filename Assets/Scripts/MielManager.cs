using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MielManager : MonoBehaviour
{
    public int PuntosTotales { get { return puntosTotales; } }
    int puntosTotales;

    public void SumarPuntos(int puntosASumar)
    {
        puntosTotales = puntosTotales + puntosASumar;
        Debug.Log(puntosTotales);
    }
}
