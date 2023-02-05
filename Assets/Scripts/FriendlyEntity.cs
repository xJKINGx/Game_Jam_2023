using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FriendlyEntity : MonoBehaviour
{
    public bool bIsAlive = true;
    private string FriendlyType = "";
    public double FriendlyHealth = 50;
    private float FriendlyDamage = 15;
    public Vector3 CurrentMousePosClicked;
    public bool bMoveToPosRecieved = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (bMoveToPosRecieved == true)
        {
            if (tag != "Human" || tag != "Deer") 
            {
                transform.position = Vector3.MoveTowards(transform.position, CurrentMousePosClicked, 2 * Time.deltaTime);
                bMoveToPosRecieved = false;
            }
        }
    }
}
