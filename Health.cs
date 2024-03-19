using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int health = 10;
    public int maxHealth = 10;

    public void TakeDamage(int damage)
    {
        health -= damage;
        print("Player's health: " + health);
    }
}
