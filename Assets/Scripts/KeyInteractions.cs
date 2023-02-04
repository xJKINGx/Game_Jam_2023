using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyInteractions : MonoBehaviour
{
    public int CurrentAbility = 1;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1) && CurrentAbility != 1)
        {
            Debug.Log("Ability 1 selected");
            CurrentAbility = 1;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2) && CurrentAbility != 2)
        {
            Debug.Log("Ability 2 selected");
            CurrentAbility = 2;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3) && CurrentAbility != 3)
        {
            Debug.Log("Ability 3 selected");
            CurrentAbility = 3;
        }
    }
}
