using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class menuOpciones : MonoBehaviour
{

    [SerializeField] private AudioMixer audioMixer;

   public void Pantallacompleta (bool pantallaCompleta)
    {
        Screen.fullScreen = pantallaCompleta;
    }
    public void CambiarVoIumen(float volumen)
    {
        audioMixer.SetFloat("Volumen", volumen);
    }
    public void CambiarCalidad(int index)
    {
        QualitySettings.SetQualityLevel(index);
    }

}
