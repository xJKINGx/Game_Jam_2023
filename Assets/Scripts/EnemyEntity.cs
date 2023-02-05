using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyEntity : MonoBehaviour
{
    public bool bIsAlive = true;
    public string EnemyType = "";
    public double EnemyHealth = 40;
    private float EnemyDamage = 10;

    [SerializeField] GameObject GreatOak;

    Vector3 AttackTarget;

    // Start is called before the first frame update
    void Start()
    {
        AttackTarget = GreatOak.transform.position;
        AttackTarget.y += 3;
        if (EnemyType == "Flame")
        {
            EnemyHealth = EnemyHealth*1.75;
            EnemyDamage = EnemyDamage*2;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (tag == "Human" && bIsAlive == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, AttackTarget, 10 * Time.deltaTime);
        }

        if (EnemyHealth <= 0)
        {
            bIsAlive = false;
        }
    }

    void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag != "Human" && other.gameObject.tag != "Deer" && other.gameObject.tag != "Tree")
        {
            other.gameObject.GetComponent<FriendlyEntity>().FriendlyHealth -= EnemyDamage;
            Debug.Log("Enemy dealt damage to friendly");
        }
        if (other.gameObject.tag == "Tree" && tag == "Human")
        {
            other.gameObject.GetComponent<TreeLogic>().TreeHealth--;
            Destroy(gameObject);
        }  
    }
}
