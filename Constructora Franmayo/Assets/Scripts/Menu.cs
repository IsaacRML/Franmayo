using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public Material material;
    public GameObject colors;

    // Start is called before the first frame update
    void Start()
    {
        colors.SetActive (false);
    }

    // Update is called once per frame
    void Update()
    {
        if (colors.active){
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "colormenu"){
        colors.SetActive (true);
        } 

        else if(other.tag == "color1"){
        material.color = Color.red;
        } 
        else if(other.tag == "color2"){
        material.color = Color.green;
        } 
        else if(other.tag == "color3"){
        material.color = Color.blue;
        } 
        else if(other.tag == "colorOg"){
        material.color = Color.white;
        } 

    }
    private void OnTriggerExit(Collider others)
    {
        if(others.tag == "colormenu")
        colors.SetActive (false);
    }
}
