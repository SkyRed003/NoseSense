using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraFollow : MonoBehaviour
{
   public Transform target;
   public Text scoreText;


    private void Update() {

      scoreText.text = ((int)(transform.position.y * 10)).ToString();
      
    }


    void LateUpdate()
    {
       if (target.position.y > transform.position.y) {
        Vector3 newPos = new Vector3(transform.position.x, target.position.y, transform.position.z);
        transform.position = newPos;
       }
    }

 
}
