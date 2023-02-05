using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class MouseHandler : MonoBehaviour
{
    public static MouseHandler instance;
   public UnityEvent<Vector3> onSetNewGoal;
    // Start is called before the first frame update
     void Awake() 
    {
        onSetNewGoal = new UnityEvent<Vector3>();
        instance = this;

    }

    // Update is called once per frame
    void Update()
    {
        
        
          Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if(Physics.Raycast(ray,out RaycastHit hit,  1000))
        {

            
            if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (hit.collider.TryGetComponent(out MouseInteractions interaction)){
                interaction.KillScriptConnection.KillEntity();
            }
             //    
        }
        // MOVEMENT OF FRIENDLIES
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {

           
                    if(onSetNewGoal != null){
                        onSetNewGoal?.Invoke(Vector3.back);
                    
                    }
            
        }

        if (Input.GetKeyDown(KeyCode.Mouse2))
        {

           if (hit.collider.TryGetComponent(out MouseInteractions interaction)){
                interaction.ResurrectionScriptConnection.ResurrectEntity("Human", interaction.transform.position);
            }
                  
            
        }
        }
    }
}
