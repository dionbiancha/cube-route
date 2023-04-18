using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour

{
    public float SpawnerTime = 5f;

    public List<GameObject> Walls = new List<GameObject>();

    void Start()
    {
        
    }

    float TimeCount;
    void Update()
    {
        TimeCount += Time.deltaTime;

        if(TimeCount >= SpawnerTime) {
            Instantiate(Walls[Random.Range(0, Walls.Count)], transform.position, transform.rotation);

            TimeCount = 0f;
        }
    }
}
