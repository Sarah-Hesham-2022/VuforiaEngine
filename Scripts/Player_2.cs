using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Player_2 : MonoBehaviour
{
   // Use this for initialization
   void Start ()
   {
        
   }
   void OnTriggerEnter(Collider other)
   {
         Debug.Log("Hello");
   
   }
   void OnTriggerExit(Collider other)
   {
        Debug.Log("Exit");
   }
}