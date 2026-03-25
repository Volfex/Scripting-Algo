using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class Accelerator : MonoBehaviour
{   
    public float accelerate = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnTriggerEnter(Collider hrac)
    {
       hrac.GetComponent<FirstPersonMovement>().speed *= accelerate;
       hrac.GetComponent<FirstPersonMovement>().runSpeed *= accelerate;
    }
    void OnTriggerExit(Collider hrac)
    {
        hrac.GetComponent<FirstPersonMovement>().speed /= accelerate;
        hrac.GetComponent<FirstPersonMovement>().runSpeed /= accelerate;
    }
}
