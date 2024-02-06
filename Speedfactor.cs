using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speedfactor : MonoBehaviour
{
    public float speed = 2.5f;

    void OnTriggerEnter(Collider other)
    {
        other.GetComponent<FirstPersonMovement>().runSpeed *= speed;
            
    }

    void OnTriggerExit(Collider other)
    {
        other.GetComponent<FirstPersonMovement>().runSpeed /= speed;
        
    }
}
