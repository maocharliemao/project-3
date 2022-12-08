using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonCollider : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public GameObject Door;

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.name == "player")
        {
            Destroy(Door);
        }
    }
}
