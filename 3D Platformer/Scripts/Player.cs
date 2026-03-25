using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public int health = 10;
    public AudioSource audio;
    public AudioClip damageSound;
    // Start is called before the first frame update
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    { 
    }
    public void getDamage(int damage)
    {
        health -= damage;
        print("Životy:" + health);
        
        if (health < 1)
        {
            int sceneIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(sceneIndex);
        }
        else
        {
            audio.PlayOneShot(damageSound);
        }
        
    }
}
