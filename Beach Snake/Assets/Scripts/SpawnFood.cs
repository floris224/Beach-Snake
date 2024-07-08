using UnityEngine;
using System.Collections.Generic;
public class SpawnFood : MonoBehaviour
{
    public List<Transform> FoodLocations = new List<Transform>();
    public GameObject prefab;
    public bool isEaten = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isEaten)
        {
            int randomPos = Random.Range(0, FoodLocations.Count);
            Instantiate(prefab,FoodLocations[randomPos]);
            isEaten = false;
        }
    }
   
}
