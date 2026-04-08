using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bonfire : MonoBehaviour
{
    public float heatPower = 0.1f;
    public float lifeTime = 15;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        lifeTime -= Time.deltaTime;
        if(lifeTime <= 0)
        {
            gameObject.SetActive(false);
        }
    }
    void OnTriggerStay(Collider other)
    {
        if(other.GetComponent<Temperature>() != null)
        {
            Temperature temperature = other.GetComponent<Temperature>();
            if(temperature.temp <= temperature.normalTemp)
            {
                 temperature.temp += heatPower * Time.deltaTime;
            }
               
        }
    }
}
