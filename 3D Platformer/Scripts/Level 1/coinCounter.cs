using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinCounter : MonoBehaviour
{

    public int coins = 0;

    public void collect()
    {
        coins ++;
        print(coins);
    }
}
