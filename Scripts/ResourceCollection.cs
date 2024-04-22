using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResourceCollection : MonoBehaviour
{
    Manager manager;


    // Start is called before the first frame update
    void Start()
    {
        manager = GameObject.FindGameObjectWithTag("Manager").GetComponent<Manager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter(Collision obj)
    {
      
        if (obj.gameObject.CompareTag("Treasure"))
        {

            manager.AddScore(10);
            obj.gameObject.SetActive(false);
        }
    }

    public void OnTriggerEnter(Collider obj)
    {
       
        if (obj.gameObject.CompareTag("ReturnDoor"))
        {
            SceneManager.LoadScene("GameComplete");
        }
    }
}
