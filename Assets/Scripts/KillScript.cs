using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillScript : MonoBehaviour
{
    public EnemyEntity EnemyEntityConnector; 
    public Animator EnemyAnimations;

    [SerializeField] Sprite DeadEnemy;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void KillEntity() {
        EnemyEntityConnector.bIsAlive = false;
        EnemyAnimations.SetBool("IsHit", true);
        this.gameObject.GetComponentInChildren<SpriteRenderer>().sprite = DeadEnemy;
        Debug.Log("Killed enemy");
    }
}