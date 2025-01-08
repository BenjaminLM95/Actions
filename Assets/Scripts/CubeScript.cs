using UnityEngine;

public class CubeScript : MonoBehaviour
{
    private Rigidbody rb;
    public Vector3 jump; 
     

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        jump = new Vector3(0.0f, 2.0f, 0.0f);
    }


    public void moveCube()
    {
        rb.AddForce(5.0f * jump, ForceMode.Impulse);
    }


    private void OnEnable()
    {
        Actions.MyEvent += moveCube;
    }

    private void OnDisable()
    {
        Actions.MyEvent -= moveCube;
    }
}
