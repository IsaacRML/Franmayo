using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuntoInteManager : MonoBehaviour
{

    [Header("Puntos de Interes")]
    public GameObject[] puntos;
    int lastPunto;

    // Start is called before the first frame update
    void Start()
    {
        foreach (GameObject punto in puntos)
        {
            punto.SetActive(false);
        }

        ChangePunto(0);
    }

    public void ChangePunto(int ID)
    {
        puntos[lastPunto].SetActive(false);
        puntos[ID].SetActive(true);

        lastPunto = ID;

    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
