using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HitboxInfo : MonoBehaviour
{
    public GameObject panel;
    public Text text1;
    string test = "";
    

    // Start is called before the first frame update
    void Start()
    {
        panel.SetActive (false);
    }

    // Update is called once per frame
    void Update()
    {
        text1.text = test;
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "alexa"){
        test = "Nuestros modelos de casas inteligentes cuentan con un dispositivo Alexa el cual provee a los usuarios con la opcion de control por voz de operaciones como encender la luz, o activar la alarma.";
        panel.SetActive (true);
        }

        else if(other.tag == "modem"){
        test = "Cada casa cuenta con internet de alta calidad, conectado usando fibra óptica, la cuál provee a los usuarios con una velocidad de 90 mb/s";
        panel.SetActive (true);
        }
        
        else if(other.tag == "cuarto1"){
        test = "Cuarto Grande";
        panel.SetActive (true);
        }
        
        

    }
    private void OnTriggerExit(Collider others)
    {
        if(others.tag == "alexa")
        panel.SetActive (false);
        
        if(others.tag == "modem")
        panel.SetActive (false);

    }
}
