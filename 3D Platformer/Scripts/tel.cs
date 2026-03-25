using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tel : MonoBehaviour
{
    public Vector3 pos = new Vector3(19, 17, -61);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        other.transform.position = pos;
    }

}
