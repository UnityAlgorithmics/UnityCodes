using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampolin : MonoBehaviour
{
    public float plusSalto = 5.2f;

    void OnTriggerEnter(Collider other)
    {
        other.GetComponent<Jump>().jumpStrength *= plusSalto;
    }

    void OnTriggerExit(Collider other)
    {
        
    }
}
