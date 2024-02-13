using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int health = 10;
    public int maxHealth;
    public int coins;
    public GameObject fireballPrefab;
    public Transform attackPoint;

    public void CollectCoins()
    {
        coins++;
        print(coins);
    }
    public void TakeDamage(int damage)
    {
        health -= damage;
        print("Player's health: " + health);
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(fireballPrefab,attackPoint.position, attackPoint.rotation);
        }


    }
}
