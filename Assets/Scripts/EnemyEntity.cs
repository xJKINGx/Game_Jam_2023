using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyEntity : MonoBehaviour
{
    public MouseInteractions MouseInteractionsConnection;
    
    private bool bIsAlive = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void KillEnemyEntity() {
        bIsAlive = false;
    }
}
