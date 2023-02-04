using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    [SerializeField] GameObject EnemyToSpawn;
    [SerializeField] GameObject SpawnLocation;

    [SerializeField] Transform TreePoint;
    // Start is called before the first frame update
    
    int num = 20; // Amount of enemies to spawn
    Vector3 point; // The point we spawn around
    float radius = 30; // How far away they spawn
    
    void Start()
    {
        point = TreePoint.position;
        for (int i = 0; i < num; i++)
        {
 
            /* Distance around the circle */
            var radians = 2 * Mathf.PI / num * i;

            /* Get the vector direction */
            var vertical = Mathf.Sin(radians);
            var horizontal = Mathf.Cos(radians);
    
            var spawnDir = new Vector3(horizontal, 0, vertical);
    
            /* Get the spawn position */
            var spawnPos = point + spawnDir * radius; // Radius is just the distance away from the point
    
            /* Now spawn */
            var enemy = Instantiate(EnemyToSpawn, spawnPos, Quaternion.identity) as GameObject;
    
            /* Rotate the enemy to face towards player */
            enemy.transform.LookAt(point);
    
            /* Adjust height */
            enemy.transform.Translate(new Vector3(0, enemy.transform.localScale.y / 2, 0));
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
