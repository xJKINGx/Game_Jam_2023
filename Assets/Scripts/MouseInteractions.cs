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
    public KillScript KillScriptConnection;

    //public Vector3 FriendlyMoveToPosValue;

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
            if (KeyScriptConnection.CurrentAbility == 1 && tag == "Human" && EnemyEntityConnection.bIsAlive == true)
            {
                KillScriptConnection.KillEntity();
            }
            else if (KeyScriptConnection.CurrentAbility == 2)
            {
                if (FriendlyEntityConnection.bIsAlive == false || EnemyEntityConnection.bIsAlive == false)
                {
                    ResurrectionScriptConnection.ResurrectEntity(tag, ResurrectionScriptConnection.ResurrectPos);
                }
            }

        }
    }
}
