using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endGame : MonoBehaviour
{
    public GameObject PopUpText;
    public GameObject RestartBUtton;

    public void start()
    {
        PopUpText.gameObject.SetActive(false);
        //gameObject.GetComponent<PlayerMovement>().enabled = false;
    }



    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "player")
        {
            PopUpText.gameObject.SetActive(true);
            RestartBUtton.gameObject.SetActive(true);
            //other.gameObject.GetComponent<PlayerMovement>.enabled = false;

            // gameObject.GetComponent<PlayerMovement>().enabled = false;
            //GetComponent<PlayerMovement>().enabled = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "player")
        {
            PopUpText.gameObject.SetActive(false);
            RestartBUtton.gameObject.SetActive(false);
                
        }
    }


}
