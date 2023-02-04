using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    [SerializeField] GameObject EnemyToSpawn;
    [SerializeField] GameObject SpawnLocation;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(EnemyToSpawn, SpawnLocation.transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
