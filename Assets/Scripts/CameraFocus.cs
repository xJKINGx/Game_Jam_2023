using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFocus : MonoBehaviour
{

    [SerializeField] float Sensitivity = 0.4f;
    [SerializeField] Transform Target;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            //Debug.Log("bababooey");
            transform.localEulerAngles += new Vector3(0.0f, Sensitivity, 0.0f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.localEulerAngles += new Vector3(0.0f, -Sensitivity, 0.0f);
            //Debug.Log("Gongaga");
        }

        transform.position = Target.position - transform.forward * 40.0f;
    }
}
