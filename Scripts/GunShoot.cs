using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GunShoot : MonoBehaviour
{
    private RaycastHit hit;
    private Ray ray;

    public GameObject impactEffect;

    public int damage = 20;


    // Update is called once per frame
    void Update()
    {
        ray = Camera.main.ViewportPointToRay(new Vector3(.5f, .5f, 0));
        if (Input.GetMouseButtonDown(0))
        {
            if(Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                GameObject impactEffectGO = Instantiate(impactEffect, hit.point, Quaternion.identity) as GameObject;
                Destroy(impactEffectGO, 1);

                GetComponent<AudioSource>().Play();

                if (hit.collider.gameObject.tag == "Enemy")
                {
                    Enemy enemy = hit.collider.gameObject.GetComponent<Enemy>();

                    enemy.TakeDamage(damage);

                }

                if (hit.collider.gameObject.tag == "BossEnemy")
                {
                    BossEnemy bossenemy = hit.collider.gameObject.GetComponent<BossEnemy>();

                    bossenemy.TakeDamage(10);

                }
            }
        }
    }




}
