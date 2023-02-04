using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MouseInteractions : MonoBehaviour
{
    public KeyInteractions KeyScriptConnection;
    public EnemyEntity EnemyEntityConnection;
    public FriendlyEntity FriendlyEntityConnection;

    public Vector3 FriendlyMoveToPosValue;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown() {
        if (Input.GetMouseButtonDown(0))
        {
            if (KeyScriptConnection.CurrentAbility == 1)
            {
                EnemyEntityConnection.KillEnemyEntity();
            }
            
            if (KeyScriptConnection.CurrentAbility == 2)
            {
                if (tag == "Human" && EnemyEntityConnection.bIsAlive == false)
                {
                    EnemyEntityConnection.ReviveEnemyEntity();
                }
                else if (tag != "Human" && FriendlyEntityConnection.bIsAlive == false)
                {
                    FriendlyEntityConnection.ReviveEntity(tag, FriendlyEntityConnection.RevivePos);
                }
            }

        }

        // MOVEMENT OF FRIENDLIES
        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log("World Pos: " + (Input.mousePosition));
            FriendlyMoveToPosValue = (Input.mousePosition);
            FriendlyMoveToPosValue.y = 0;
        }
    }
}
