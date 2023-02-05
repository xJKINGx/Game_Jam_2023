using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;

public class MouseInteractions : MonoBehaviour
{
    public KeyInteractions KeyScriptConnection;
    public EnemyEntity EnemyEntityConnection;
    public FriendlyEntity FriendlyEntityConnection;
    public ResurrectionScript ResurrectionScriptConnection;
    public KillScript KillScriptConnection;

    public Vector3 FriendlyMoveToPosValue;

    Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
        MouseHandler.instance.onSetNewGoal.AddListener( OnSetNewGoal);
    }

    private void OnDestroy() {
         MouseHandler.instance.onSetNewGoal.RemoveListener( OnSetNewGoal);
    }

    private void OnSetNewGoal(Vector3 newPos){
        Debug.Log("Message REceived");
        GetComponent<FriendlyEntity>().bMoveToPosRecieved = true;
        GetComponent<FriendlyEntity>().CurrentMousePosClicked = newPos;
        
        
    }

    // Update is called once per frame
    void Update()
    {

        
return;
         if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Debug.Log("awdawdawd");
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
        // MOVEMENT OF FRIENDLIES
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            Debug.Log("World Pos: " + (Input.mousePosition));
            FriendlyMoveToPosValue = (Input.mousePosition);
            FriendlyMoveToPosValue.y = 0;
            FriendlyEntityConnection.CurrentMousePosClicked = FriendlyMoveToPosValue;
            FriendlyEntityConnection.bMoveToPosRecieved = true;
        }
    }

    void OnMouseDown() {
       
    }
}
