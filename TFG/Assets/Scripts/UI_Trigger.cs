using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Trigger : MonoBehaviour
{

    public GameObject player;
    public GameObject UI_to_activate;


    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Player")
        {
            UI_to_activate.SetActive(true);
        }
    }

}
