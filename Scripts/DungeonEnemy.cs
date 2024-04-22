using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DungeonEnemy : MonoBehaviour
{

    public GameObject Enemy;

    // Start is called before the first frame update
    void Start()
    {
        for(int i=0; i<4; i++)
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
        Instantiate(Enemy, new Vector3(Random.Range(22.0f, -22.0f), 1.37f, Random.Range(12.5f, -13.0f)), transform.rotation);
    }
}
