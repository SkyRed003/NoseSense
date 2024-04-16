using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mongolGen : MonoBehaviour
{
   [SerializeField] private GameObject mongolfiera;
  private float timer = 0f;
    private float spawnInterval = 15f;
    private float fixedX = 46f;
  
    void Update()
    {
        // Incrementa il timer ad ogni frame
        timer += Time.deltaTime;

        // Se il timer supera l'intervallo di spawn, spawniamo un sottomarino e resetta il timer
        if (timer >= spawnInterval)
        {
            SpawnMongolfiera();
            timer = 0f;
        }
    }

    void SpawnMongolfiera()
    {
        // Calcola una posizione casuale per lo spawn del sottomarino
         float randomY = Random.Range(1000f, 1200f);
         
       Vector3 spawnPosition = new Vector3(fixedX, randomY);
        // Spawn del sottomarino alla posizione casuale
        Instantiate(mongolfiera, spawnPosition, Quaternion.identity);
    }
}
