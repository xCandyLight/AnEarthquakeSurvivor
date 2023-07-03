using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Esya : MonoBehaviour , IInteractable
{

    [SerializeField]

    private bool pickUpAllowed;

    public void Interact()
    {
        Destroy(gameObject);
    }


    // Use this for initialization
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        // if (pickUpAllowed && Input.GetKeyDown(KeyCode.E))
        //PickUp();

    }

    /*private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("karakter"))
        {
            pickUpAllowed = true;
        }        
    }
    
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("karakter"))
        {
            pickUpAllowed = false;
        }
    }

    private void PickUp()
    {
        Destroy(gameObject);

    }*/
}
