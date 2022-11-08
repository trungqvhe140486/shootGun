using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletHit : MonoBehaviour
{
    public float weaponDamage;

    projectileController myPC;

    public GameObject bulletExplosion;

    private void Awake()
    {
        myPC = GetComponentInParent<projectileController>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Shootable")
        {
            myPC.removeForce();
            Instantiate(bulletExplosion, transform.position, transform.rotation);
            Destroy(gameObject);
            if(other.gameObject.layer == LayerMask.NameToLayer("enemy"))
            {
                enemyHeath hurtEnemy = other.gameObject.GetComponent<enemyHeath>();
                hurtEnemy.addDamge(weaponDamage);
            }
        }
    }


    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Shootable")
        {
            myPC.removeForce();
            Instantiate(bulletExplosion, transform.position, transform.rotation);
            Destroy(gameObject);
            if (other.gameObject.layer == LayerMask.NameToLayer("enemy"))
            {
                enemyHeath hurtEnemy = other.gameObject.GetComponent<enemyHeath>();
                hurtEnemy.addDamge(weaponDamage);
            }
        }
    }



}
