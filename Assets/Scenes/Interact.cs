using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{
    public GameObject TextDialog;
    public bool isColliding;

    // Update is called once per frame
    void Update()
    {
        

    }
    void OnTriggerEnter2D(Collider2D NPC)
    {
        if (NPC.CompareTag("Player"))
        {
            TextDialog.SetActive(true);
        }
    }

    void OnTriggerExit2D(Collider2D NPC)
    {
        TextDialog.SetActive(false);
    }
}
