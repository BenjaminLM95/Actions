using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAction : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Switch")) 
        {
            Action.MyEvent?.Invoke(); 
        }
    }
}
