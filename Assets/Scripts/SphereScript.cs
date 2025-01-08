using UnityEngine;

public class SphereScript : MonoBehaviour
{
    private Rigidbody rb;
    public Vector3 jump; 
    
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        jump = new Vector3(0.0f, 0.0f, 3.0f);
    }

    public void moveSphere() 
    {
       rb.AddForce(2.5f * jump, ForceMode.Impulse); 
    }
     

    private void OnEnable()
    {
        Actions.MyEvent += moveSphere;
    }

    private void OnDisable()
    {
        Actions.MyEvent -= moveSphere;
    }
}
