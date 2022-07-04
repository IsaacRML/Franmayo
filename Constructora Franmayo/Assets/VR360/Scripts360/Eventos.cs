using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Eventos : MonoBehaviour
{

    [System.Serializable]
    public class Event : UnityEvent<int> { }

    [Header("Eventos")]
    public Event[] events;

    int idEvent;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Events();
    }

    private void Events()
    {
        events[idEvent].Invoke(idEvent);
    }

    public void Event_Down(int _ID)
    {
        idEvent = _ID;
    }


}
