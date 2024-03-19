using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Misile : MonoBehaviour
{
    public float speed = 2.0f;

    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            Destroy(other.gameObject);
        }
   
    }

    void Start()
    {
        Destroy(gameObject, 3);
    }


}
