using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int health = 10;
    private int coins;
    public void TakeDamage(int damage)
    {
        health-=damage;
        print("Здоровье игрока" + health);
    }
    public void CollectCoins()
    {
        coins++;
        print("Cobrannie monetku"+coins);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
