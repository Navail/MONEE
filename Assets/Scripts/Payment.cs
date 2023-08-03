using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Code written by Carlos A. Rodriguez 14/14/2022

//Code used to give the player the ability to pay in order to exit the store
public class Payment : MonoBehaviour
{
     private AudioSource source;
    [SerializeField] private AudioClip clip;

    //If you want to remove the barrier mechanic, please turn lines 13, 27, 28, 29, and 30 into comments

    //Both these variables must be set in the Inspector
    [SerializeField] private Checkout checkout; //Reffers to the Game Object holding the Checkout script
    [SerializeField] private GameObject barrier; //Reffers to an invisible wall preventing the player to leave without paying
    private void Start()
    {
        source = GetComponent<AudioSource>();
    }
    //Meant to be triggered whenever an object is placed in the designated area
    //Please make sure the Collider that is used has the "Is Trigger" set to true
    //Also remmember that in order for the Collision to be detected, at least one of the objects must have a RigidBody component

    private void OnTriggerEnter(Collider other)
    {
        //Checks if the object is money
        if (other.CompareTag("Money"))
        {
            Money money = other.gameObject.GetComponent<Money>();
            checkout.total -= money.value;

            //Checks if ennough money has been given and removes the invisible barrier
            if (checkout.total <= 0)
            {
                source.Play();
                
                barrier.SetActive(false);
            }

        }
    }

}
