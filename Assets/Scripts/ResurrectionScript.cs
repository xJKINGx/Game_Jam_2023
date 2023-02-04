using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResurrectionScript : MonoBehaviour
{
    [SerializeField] GameObject ResurrectedHuman;
    [SerializeField] GameObject ResurrectedDeer;

    public Vector3 ResurrectPos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ResurrectEntity(string tag, Vector3 ResurrectPos) {
        ResurrectPos = transform.position;
        if (tag == "Human")
        {
            Destroy(this);
            Instantiate(ResurrectedHuman, ResurrectPos, Quaternion.identity);
        }
        else if (tag == "Deer")
        {
            Destroy(this);
            Instantiate(ResurrectedDeer, ResurrectPos, Quaternion.identity);
        }
    }
}
