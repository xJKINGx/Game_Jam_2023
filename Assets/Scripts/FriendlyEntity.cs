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

    Camera cam;

    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 MousePos = Input.mousePosition;
        MousePos.z = 100f;
        MousePos = cam.ScreenToWorldPoint(MousePos);

        if (Input.GetMouseButtonDown(1))
        {
            //bMoveToPosRecieved = true;
            //FriendlyMoveTo();

            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 200))
            {
                //Debug.Log(hit.transform.position);
                FriendlyMoveToPosValue = hit.point;
                bMoveToPosRecieved = true;
            }

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

        if (bMoveToPosRecieved)
        {
            FriendlyMoveTo();
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

            //Debug.Log("World Pos: " + (Input.mousePosition));



            if (tag != "Human" && tag != "Deer" && bIsAlive == true)
            {
                transform.position = Vector3.MoveTowards(transform.position, FriendlyMoveToPosValue, 5 * Time.deltaTime);
            }

            if (FriendlyMoveToPosValue == transform.position)
            {
                bMoveToPosRecieved = false;
                
            }
        

        Debug.Log("No error?");

        /*if (tag != "Human" && tag != "Deer" && bIsAlive == true) 
        {
            transform.position = Vector3.MoveTowards(transform.position, FriendlyMoveToPosValue, 4 * Time.deltaTime);
            Debug.Log("I should be moving");
        }*/


    }
    void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag == "Human")
        {
            other.gameObject.GetComponent<EnemyEntity>().EnemyHealth -= FriendlyDamage;
            Debug.Log("Friendly dealth damage to enemy");
        }  
    }
}


