using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingSardine : MonoBehaviour
{
       public GameObject prefabSardine;
    public float speed;

    void Start()
{

    StartCoroutine(DestroyAfterDelay(3f));

}
    // Update is called once per frame
    void Update()
    {
      
      Vector3 newPosition = transform.position + Vector3.left * speed * Time.deltaTime;
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
