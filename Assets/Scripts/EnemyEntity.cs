using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyEntity : MonoBehaviour
{
    // public MouseInteractions MouseInteractionsConnection;
    
    public bool bIsAlive = true;
    private string EnemyType = "";
    public double EnemyHealth = 40;
    private float EnemyDamage = 10;
    public Vector3 EnemyDeathPos;

    // Start is called before the first frame update
    void Start()
    {
        if (EnemyType == "Flame")
        {
            EnemyHealth = EnemyHealth*1.75;
            EnemyDamage = EnemyDamage*2;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void KillEnemyEntity() {
        bIsAlive = false;
        //Endre til død mesh
        Debug.Log("Gungaga");
    }

    public void ReviveEnemyEntity() {
        EnemyDeathPos = transform.position;
    }
}
