using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MouseInteractions : MonoBehaviour
{
    public KeyInteractions KeyScriptConnection;
    public EnemyEntity EnemyEntityConnection;
    public FriendlyEntity FriendlyEntityConnection;
    public ResurrectionScript ResurrectionScriptConnection;

    [SerializeField] GameObject CorpseMech;

    public int Mana = 100;
    public int MaxMana = 100;
    public int EnemiesKilled;

    //public Vector3 FriendlyMoveToPosValue;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Mana < MaxMana)
        {
            Mana +=1;
        }
    }

    void OnMouseDown() {
        if (Input.GetMouseButtonDown(0))
        {
            if (KeyScriptConnection.CurrentAbility == 1 && tag == "Human" && EnemyEntityConnection.bIsAlive == true)
            {
                if (Mana >= 10)
                {
                    EnemyEntityConnection.bIsAlive = false;
                }
            }
            else if (KeyScriptConnection.CurrentAbility == 2)
            {
                if (FriendlyEntityConnection.bIsAlive == false || EnemyEntityConnection.bIsAlive == false)
                {
                    if (Mana >= 20)
                    {
                        ResurrectionScriptConnection.ResurrectEntity(tag, ResurrectionScriptConnection.ResurrectPos);
                    }
                }
            }
            else if (KeyScriptConnection.CurrentAbility == 3)
            {
                if (Mana == 100 && EnemiesKilled >= 20) {
                    Instantiate(CorpseMech, Input.mousePosition, Quaternion.identity);
                }
            }

        }
    }
}
