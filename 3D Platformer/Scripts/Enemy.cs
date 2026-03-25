using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 1.5f;
    public int damage = 2;
    public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
       transform.LookAt(target);
    }

    void OnTriggerEnter(Collider other)
    {
        other.GetComponent<Player>().getDamage(damage);
    }
}
