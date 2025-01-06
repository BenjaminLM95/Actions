using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
{
    private Rigidbody rb;
    public Vector3 jump;

    public void moveCube()
    {
        rb.AddForce(5.0f * jump, ForceMode.Impulse);
    }


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        jump = new Vector3(0.0f, 2.0f, 0.0f);
       
    }

    // Update is called once per frame
    void Update()
    {

    }
}
