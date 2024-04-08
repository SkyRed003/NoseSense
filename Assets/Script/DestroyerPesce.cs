using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyerPesce : MonoBehaviour
{
   private void OnTriggerEnter(Collider other) 
   {
    if (other.CompareTag("Pesce")) {

        Destroy(gameObject);
    }
    
   }
}
