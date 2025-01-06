using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereScript : MonoBehaviour
{
    private Rigidbody rb;
    public Vector3 jump;

    public void moveSphere() 
    {
        rb.AddForce(2.5f * jump, ForceMode.Impulse); 
    }


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        jump = new Vector3(0.0f, 0.0f, 3.0f);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
