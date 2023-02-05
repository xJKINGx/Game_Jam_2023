using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FriendlyEntity : MonoBehaviour
{
    public MouseInteractions mouseInteractionsConnection;

    public bool bIsAlive = true;
    //public bool bFriendlyIsAllowedToMove = false;
    private string FriendlyType = "";
    public double FriendlyHealth = 50;
    private float FriendlyDamage = 15;
    public Vector3 FriendlyMoveToPosValue;
    public bool bMoveToPosRecieved = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            FriendlyMoveTo();
            /*Debug.Log("World Pos: " + (Input.mousePosition));
            FriendlyMoveToPosValue = new Vector3(1,1,1);
            FriendlyMoveToPosValue = transform.position;
            FriendlyMoveToPosValue.x = (Input.mousePosition.x);
            FriendlyMoveToPosValue.z = (Input.mousePosition.z);
            Debug.Log("No error?");

            /*if (tag != "Human" && tag != "Deer" && bIsAlive == true) 
            {
                transform.position = Vector3.MoveTowards(transform.position, FriendlyMoveToPosValue, 4 * Time.deltaTime);
                Debug.Log("I should be moving");
            }*/

            /*if (tag != "Human" && tag != "Deer" && bIsAlive == true)
            {
               transform.position = Vector3.MoveTowards(transform.position, FriendlyMoveToPosValue, 1 * Time.deltaTime);
            }*/

        }
        /*if (tag != "Human" && tag != "Deer" && bIsAlive == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, FriendlyMoveToPosValue, 1 * Time.deltaTime);
        }*/
        /*if (bMoveToPosRecieved == true)
        {
            if (tag != "Human" || tag != "Deer") 
            {
                Debug.Log("I should be moving");
                transform.position = Vector3.MoveTowards(transform.position, CurrentMousePosClicked, 2 * Time.deltaTime);
                bMoveToPosRecieved = false;
            }
        }*/
    }
    public void FriendlyMoveTo() {
        Debug.Log("World Pos: " + (Input.mousePosition));
        FriendlyMoveToPosValue = new Vector3(1,1,1);
        FriendlyMoveToPosValue = transform.position;
        FriendlyMoveToPosValue.x = (Input.mousePosition.x);
        FriendlyMoveToPosValue.z = (Input.mousePosition.z);
        Debug.Log("No error?");

        /*if (tag != "Human" && tag != "Deer" && bIsAlive == true) 
        {
            transform.position = Vector3.MoveTowards(transform.position, FriendlyMoveToPosValue, 4 * Time.deltaTime);
            Debug.Log("I should be moving");
        }*/

        if (tag != "Human" && tag != "Deer" && bIsAlive == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, FriendlyMoveToPosValue, 1 * Time.deltaTime);
        }
}
}


