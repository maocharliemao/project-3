using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerInteraction : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textLives;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        textLives.text = " Lifes: " + eventBus.Current.ReturnLives();

        if (Input.GetKeyDown("r"))
        {
            print(eventBus.Current.ReturnLives());
        }

        if (Input.GetKeyDown("q"))
        {
            eventBus.Current.RemoveLife();
        }


        if (Input.GetKeyDown("o"))
        {
            eventBus.Current.Lighton();
        }

        if (Input.GetKeyDown("p"))
        {
            eventBus.Current.Lightoff();
        }
    }  
}
