using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioVolumen : MonoBehaviour
{
    public Slider controlVolumen;       //La barra que representa la cantidad de volumen en el juego.

    public GameObject[] audios;         //Lista para ubicar todos los objetos que encuentre.

    private void Start()
    {
        audios = GameObject.FindGameObjectsWithTag("audio");  //Busca todos los objetos con el tag audio.
        controlVolumen.value = PlayerPrefs.GetFloat("volumenSave", 1f); //Carga la informació preguardada de no tenerla lo deja con valor 1.
    }

    private void Update()
    {
        foreach (GameObject au in audios)
            au.GetComponent<AudioSource>().volume = controlVolumen.value;    //Carga en todos los objetos con el tag audio el valor que corresponda.
    }

    public void guardarVolumen()
    {
        PlayerPrefs.SetFloat("volumenSave", controlVolumen.value);     //Guarda la información cuando cambiamos el slider.
    }
}
