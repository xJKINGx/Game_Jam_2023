using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FriendlyEntity : MonoBehaviour
{
    public MouseInteractions mouseInteractionsConnection;

    public bool bIsAlive = true;
    //public bool bFriendlyIsAllowedToMove = false;
    public string FriendlyType = "";
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
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 200))
            {
                //Debug.Log(hit.transform.position);
                FriendlyMoveToPosValue = hit.point;
                bMoveToPosRecieved = true;
            }
        }

        if (bMoveToPosRecieved)
        {
            FriendlyMoveTo();
        }

        if (FriendlyHealth <= 0)
        {
            bIsAlive = false;
        }
    }
    public void FriendlyMoveTo() {
        if (tag != "Human" && tag != "Deer" && bIsAlive == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, FriendlyMoveToPosValue, 5 * Time.deltaTime);
        }

        if (FriendlyMoveToPosValue == transform.position)
        {
            bMoveToPosRecieved = false;
                
        }
        
        Debug.Log("No error?");
    }
    void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag == "Human")
        {
            other.gameObject.GetComponent<EnemyEntity>().EnemyHealth -= FriendlyDamage;
            Debug.Log("Friendly dealth damage to enemy");
        }  
    }
}


