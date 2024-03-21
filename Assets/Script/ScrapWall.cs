using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrapWall : MonoBehaviour
{
   private void OnTriggerEnter2D(Collider2D other) 
   {
     if (other.gameObject.tag == "RightWall") 
        transform.position = new Vector3(-3.25f , transform.position.y, transform.position.z); 
    
    
     if (other.gameObject.tag == "LeftWall") 
      transform.position = new Vector3(3.25f, transform.position.y, transform.position.z);
    
   }
}
