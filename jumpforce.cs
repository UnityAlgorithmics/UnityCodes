using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpforce : MonoBehaviour
{
    public float jumpg = 2f;

    void OnTriggerEnter(Collider other)
    {
        other.GetComponent<Jump>().jumpStrength *= jumpg;
            
    }

    void OnTriggerExit(Collider other)
    {
        other.GetComponent<Jump>().jumpStrength /= jumpg;
        
    }
}
