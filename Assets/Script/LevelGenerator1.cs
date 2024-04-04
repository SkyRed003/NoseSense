using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;
public class LevelGenerator1 : MonoBehaviour
{
  [SerializeField] private float horizontalLimit;
  [SerializeField] private Vector2 verticalRange;
  [SerializeField] private PlatformController prefab;

  public float amount = 100;


    private void Start()
    {
        CreateLevel();
        
    }

private void CreateLevel() {
    var position = Vector2.zero;
    for (int i = 0; i < amount; i++) {
        position.y += Random.Range(verticalRange.x, verticalRange.y);
        position.x = Random.Range(-horizontalLimit, horizontalLimit);
        Instantiate(prefab, position, Quaternion.identity);
    }

}
    // Update is called once per frame
    void Update()
    {
        
    }
}
