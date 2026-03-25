using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinScript : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        
        other.GetComponent<coinCounter>().collect();
        Destroy(gameObject);
    }
}
