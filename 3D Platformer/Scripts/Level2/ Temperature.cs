using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Temperature : MonoBehaviour
{
    public Health health;
    public float temp = 36.6f;
    public float normalTemp = 36.6f;
    public float tempFreeze = 34f;
    public float tempDecreseSpeed = 0.05f;
    public int freezeDamage = 2;
    public float freezeSpeed = 1f;

    public float freezeDelay = 2f;
    public float freezeTimer = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        temp -= tempDecreseSpeed * Time.deltaTime;
        if(temp <= tempFreeze)
        {
            if(freezeTimer <= 0f)
            {
                health.TakeDamage(freezeDamage);
                freezeTimer += freezeDelay;
            }
            else
            {
                freezeTimer -= Time.deltaTime;
            }
            
        }
    }
}
