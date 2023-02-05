using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityArtSelection : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MoveSelection(int ability)
    {
        switch(ability)
        {
            case 1:
            transform.position = new Vector3(160, 140, 0);
            break;
            case 2:
            transform.position = new Vector3(310, 140, 0);
            break;
            case 3:
            transform.position = new Vector3(460, 140, 0);
            break;
        }
    }
}
