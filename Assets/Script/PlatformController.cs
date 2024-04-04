using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformController : MonoBehaviour
{
  [SerializeField] private float force;
  [SerializeField] public Animator myAnimationController;

  private void OnCollisionEnter2D(Collision2D col) {

    if(col.transform.CompareTag("Player")) {
        var player = col.transform.GetComponent<MovemenPlayer>();
        player.Jump(force);
    }
    
    if(col.transform.CompareTag("Player")) { 
        myAnimationController.SetBool("salto", true);


 
      }
  }

  private void OnCollisionExit2D(Collision2D col) {
     if(col.transform.CompareTag("Player")) { 
        myAnimationController.SetBool("salto", false);


 
      }

  }
}