using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuScreen : MonoBehaviour
{
    private float elapsed = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void FixedUpdate()
    {
        elapsed += Time.deltaTime;
     if (elapsed >= 2f) {
         elapsed = elapsed % 2f;
			Destroy(gameObject);
     }
    }
}
