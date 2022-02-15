using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatyMcSinky : MonoBehaviour
{
    public Rigidbody rigidBody;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         if (Input.GetKeyDown(KeyCode.Space))
        {
            rigidBody.AddForce(Vector3.up * 100f);
        }        
        
    }
}
