using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{

    int score = 0;
    public Text ScoreText;

    int health = 100;
    public Text HealthText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddScore(int toAdd)
    {
        score += toAdd;
        ScoreText.text = "Score: " + score.ToString();
    }
    
    public void DecreaseHealth(int toDecrease)
    {
        health -= toDecrease;

        if(health <= 0)
        {
            SceneManager.LoadScene("Game Over");
        }


        HealthText.text = "Health: " + health.ToString();
    }
}
