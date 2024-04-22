using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

    public GameObject Enemy;

    // Start is called before the first frame update
    void Start()
    {
        for(int i=0; i<10; i++)
        {
            SpawnTheEnemy();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnTheEnemy()
    {
        Instantiate(Enemy, new Vector3(Random.Range(540.0f, 680.0f), 1.37f, Random.Range(229.0f, 354.0f)), transform.rotation);
    }
}
