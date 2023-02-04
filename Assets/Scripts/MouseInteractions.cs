using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MouseInteractions : MonoBehaviour
{
    public KeyInteractions KeyScriptConnection;
    public EnemyEntity EnemyEntityConnection;

    public Vector3 FriendlyMoveToPosValue;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (KeyScriptConnection.CurrentAbility == 1)
            {
                // Kill animal
            }
            else if (KeyScriptConnection.CurrentAbility == 2)
            {
                // Revive animal
            }
            else if (KeyScriptConnection.CurrentAbility == 3)
            {
                
            }
        }
        // MOVEMENT OF FRIENDLIES
        else if (Input.GetMouseButtonDown(1))
        {
            Debug.Log("World Pos: " + (Input.mousePosition));
            FriendlyMoveToPosValue = (Input.mousePosition);
            FriendlyMoveToPosValue.y = 0;
        }
    }
}
