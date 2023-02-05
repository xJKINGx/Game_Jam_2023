using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillScript : MonoBehaviour
{
    public EnemyEntity EnemyEntityConnection; 
    public FriendlyEntity FriendlyEntityConnection;
    public Animator EnemyAnimations;
    public MouseInteractions MouseInteractionsConnection;

    [SerializeField] Sprite DeadEnemy;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (EnemyEntityConnection.bIsAlive == false || FriendlyEntityConnection.bIsAlive == false)
        {
            KillEntity();
        }
    }

    public void KillEntity() {
        EnemyEntityConnection.bIsAlive = false;
        EnemyAnimations.SetBool("IsHit", true);
        this.gameObject.GetComponentInChildren<SpriteRenderer>().sprite = DeadEnemy;
        Debug.Log("Killed enemy");
        MouseInteractionsConnection.EnemiesKilled += 1;
    }
}
