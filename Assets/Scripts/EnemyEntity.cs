using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyEntity : MonoBehaviour
{
    public FriendlyEntity FriendlyEntityConnection;

    [SerializeField] Sprite DeadEnemy;
    
    public bool bIsAlive = true;
    public string EnemyType = "";
    public double EnemyHealth = 40;
    private float EnemyDamage = 10;
    public Vector3 EnemyDeathPos;

    public Animator EnemyAnimations;

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
        EnemyAnimations.SetBool("IsHit", true);
        this.gameObject.GetComponentInChildren<SpriteRenderer>().sprite = DeadEnemy;
        //this.gameObject.GetComponent<SpriteRenderer>().sprite = DeadEnemy;
        

        Debug.Log("Killed enemy");
    }

    public void ReviveEnemyEntity() {
        EnemyDeathPos = transform.position;
        FriendlyEntityConnection.ReviveEntity(EnemyType, EnemyDeathPos);
        Destroy(this);
        Debug.Log("Revived enemy as friendly");
    }
}
