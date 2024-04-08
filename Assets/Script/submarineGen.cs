using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class submarineGen : MonoBehaviour
{
    [SerializeField] private GameObject sottomarino;
  private float timer = 0f;
    private float spawnInterval = 10f;
    private float fixedX = -29.5f;
  
    void Update()
    {
        // Incrementa il timer ad ogni frame
        timer += Time.deltaTime;

        // Se il timer supera l'intervallo di spawn, spawniamo un sottomarino e resetta il timer
        if (timer >= spawnInterval)
        {
            SpawnSottomarino();
            timer = 0f;
        }
    }

    void SpawnSottomarino()
    {
        // Calcola una posizione casuale per lo spawn del sottomarino
         float randomY = Random.Range(20f, 70f);
         
       Vector3 spawnPosition = new Vector3(fixedX, randomY);
        // Spawn del sottomarino alla posizione casuale
        Instantiate(sottomarino, spawnPosition, Quaternion.identity);
    }
}
