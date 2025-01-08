using UnityEngine;

public class TriggerAction : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Switch")) 
        {
            Actions.MyEvent?.Invoke(); 
            
        }
    }
}
