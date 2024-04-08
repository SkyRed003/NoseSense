using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SardineGen : MonoBehaviour
{
    [SerializeField] private GameObject sardine;
    private float timer = 0f;
    private float spawnInterval = 5f;
    private float fixedX = 22f;
  
    void Update()
    {
        // Incrementa il timer ad ogni frame
        timer += Time.deltaTime;

        // Se il timer supera l'intervallo di spawn, spawniamo un sottomarino e resetta il timer
        if (timer >= spawnInterval)
        {
            SpawnSardine();
            timer = 0f;
        }
    }

    void SpawnSardine()
    {
        // Calcola una posizione casuale per lo spawn del sottomarino
         float randomY = Random.Range(20f, 70f);
         
       Vector3 spawnPosition = new Vector3(fixedX, randomY);
        // Spawn del sottomarino alla posizione casuale
        Instantiate(sardine, spawnPosition, Quaternion.identity);
    }
}
