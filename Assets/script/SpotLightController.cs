using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpotLightController : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        eventBus.Current.lightsGoOn += turnLightOn;
        eventBus.Current.lightsGoOff += turnLightOff;
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    public void turnLightOn() {
        gameObject.GetComponent<BoxCollider>().enabled = true;
    }

    public void turnLightOff() {
        gameObject.GetComponent<BoxCollider>().enabled = false;
    }
}