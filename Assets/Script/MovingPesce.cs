using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPesce : MonoBehaviour
{
   public GameObject prefabPesce;
  public float speed;

    void Start()
     {
        StartCoroutine(DestroyAfterDelay(4f));
    }

    // Update is called once per frame
    void Update()
    {
      
      Vector3 newPosition = transform.position + Vector3.right * speed * Time.deltaTime;
      transform.position = newPosition;
        
    }

     IEnumerator DestroyAfterDelay(float delay)
    {
        // Aspetta per il numero di secondi specificato
        yield return new WaitForSeconds(delay);

        // Distrugge il gameObject
        Destroy(gameObject);
    }
}

