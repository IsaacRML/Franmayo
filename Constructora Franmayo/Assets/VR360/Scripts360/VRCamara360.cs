using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRCamara360 : MonoBehaviour
{

    public Texture2D puntero;
    public Vector2 sensibility;

    float movx;
    float movy;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;      
    }

    // Update is called once per frame
    void Update()
    {

        float hor = Input.GetAxis("Mouse X");
        float ver = Input.GetAxis("Mouse Y");

        movx += sensibility.x * hor;
        movy -= sensibility.y * ver;

        movy = Mathf.Clamp(movy, -80, 80);

        transform.eulerAngles = new Vector3(movy, movx, 0.0f);


    }


    private void OnGUI()
    {
        Rect rect = new Rect(Screen.width / 2, Screen.height / 2, puntero.width, puntero.height);
        GUI.DrawTexture(rect, puntero);
    }


}
