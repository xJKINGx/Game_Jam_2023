using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FriendlyEntity : MonoBehaviour
{
    public bool bIsAlive = true;
    private string FriendlyType = "";
    public double FriendlyHealth = 50;
    private float FriendlyDamage = 15;
    public Vector3 SpawnFriendlyPos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ReviveFriendlyEntity(string tag) {
        bIsAlive = true;
        if (tag == "Human")
        {
            // Spawn friendly entity
        }
    }
}
