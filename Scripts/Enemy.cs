using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 100;
    Manager manager;

    void Start()
    {
        manager = GameObject.FindGameObjectWithTag("Manager").GetComponent<Manager>();
    }

    void OnCollisionEnter(Collision obj)
    {
        if (obj.gameObject.CompareTag("player"))
        {
            manager.DecreaseHealth(5);
        }
    }

    // Start is called before the first frame update
    public void TakeDamage(int damage)
    {
        health -= damage;

        if(health <= 0)
        {
            Destroy(gameObject);

            manager.AddScore(1);
        }
    }
}
