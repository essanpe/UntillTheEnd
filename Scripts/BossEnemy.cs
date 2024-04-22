using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossEnemy : MonoBehaviour
{
    public int health = 100;
    Manager manager;

    public GameObject Treasure;
    public GameObject ReturnDoor;

    public Text BossHealthText;

    void Start()
    {
        manager = GameObject.FindGameObjectWithTag("Manager").GetComponent<Manager>();

        Treasure.SetActive(false);
        ReturnDoor.SetActive(false);
    }



    void OnCollisionEnter(Collision obj)
    {
        if (obj.gameObject.CompareTag("player"))
        {
            manager.DecreaseHealth(10);
        }
    }

    // Start is called before the first frame update
    public void TakeDamage(int damage)
    {
        health -= damage;
        BossHealthText.text = "Boss Health: " + health.ToString();

        if (health <= 0)
        {
            gameObject.GetComponent<Animator>().Play("Death");

            //Destroy(gameObject);

            manager.AddScore(10);

            BossHealthText.text = "Boss Defeated!";

            Treasure.SetActive(true);
            ReturnDoor.SetActive(true);
        }
    }
}
