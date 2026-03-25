using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinCollect : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        
        other.GetComponent<coinCounter>().collect();
        Destroy(gameObject);
    }
}
