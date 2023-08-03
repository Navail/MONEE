using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Code written by Carlos A. Rodriguez 14/14/2022

//Code used to scan objects and determine total price
public class Checkout : MonoBehaviour
{
    
    //Total price of purchaes, must start at 0
    public float total = 0;

    //Meant to be triggered whenever an object is placed in the designated area
    //Please make sure the Collider that is used has the "Is Trigger" set to true
    //Also remmember that in order for the Collision to be detected, at least one of the objects must have a RigidBody component
    private void OnTriggerEnter(Collider other)
    {
        //Checks if the object is a product that can be purchased, if its not then nothing happens
        if (other.CompareTag("Item"))
        {
            Items item = other.gameObject.GetComponent<Items>();
            total += item.price;
        }
    }

}
