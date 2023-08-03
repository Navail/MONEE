using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Code written by Carlos A. Rodriguez 14/14/2022

//Code used to determine price of product
//All Game Objects with this script must have the tag "Item"
public class Items : MonoBehaviour
{
    //The price has to be set for each individual object via the inspector. Default value is 1
    [SerializeField] public float price = 1;

}
