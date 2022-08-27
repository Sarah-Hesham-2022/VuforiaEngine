using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Collision : MonoBehaviour
{
    private AudioSource collision;
    int Count = 1;
   // Use this for initialization
   void Start ()
   {
        collision = GetComponent<AudioSource>();
   }
   void OnTriggerEnter(Collider other)
   {
         Debug.LogError("Collision  "+Count.ToString());

         Debug.LogError("Collider is called "+other.name);

        collision.Play();
        

    }
    void OnTriggerExit(Collider other)
   {
        Debug.LogError("Exit Collision " + Count.ToString());
        Count++;
    }
}