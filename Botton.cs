using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Botton : MonoBehaviour
{
    public Animator button;
    public Animator toOpen;

    // Start is called before the first frame update
    void Start()
    {
        button.enabled = false;
        
    }

    private void OnTriggerEnter(Collider other)
    {
        button.enabled=true;
        toOpen.enabled = true;
    }

}
