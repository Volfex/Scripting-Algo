using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int health;
    public int maxHealth = 10;
    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;   
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        // přidat smrt
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
