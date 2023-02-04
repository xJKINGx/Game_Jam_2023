using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FriendlyEntity : MonoBehaviour
{
    [SerializeField] Sprite ResurrectedHuman;
    [SerializeField] Sprite ResurrectedDeer;

    public bool bIsAlive = true;
    private string FriendlyType = "";
    public double FriendlyHealth = 50;
    private float FriendlyDamage = 15;
    public Vector3 RevivePos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ReviveEntity(string tag, Vector3 RevivePos) {
        bIsAlive = true;
        if (tag == "Human")
        {
            Instantiate(ResurrectedHuman, RevivePos, Quaternion.identity);
        }
        else {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = ResurrectedDeer;
            Debug.Log("Revived friendly");
        }
    }

    void MoveToSpot() {

    }
}
