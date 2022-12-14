using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyDamege : MonoBehaviour
{

    public float damage;
    float dameRate = 0.5f;
    public float pushBackForce;
    float nextDamege;

    // Start is called before the first frame update
    void Start()
    {
        nextDamege = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
  
    void OnTriggerStay2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player" && nextDamege < Time.time)
        {
            playerHealth thePlayerHealth = other.gameObject.GetComponent<playerHealth> ();
            thePlayerHealth.addDamage(damage);
            nextDamege = dameRate + Time.time;

            pushBack (other.transform);
        }
    }
    void pushBack(Transform pushedObject)
    {
        Vector2 pushDirection = new Vector2(0, (pushedObject.position.y - transform.position.y)).normalized;
        pushDirection *= pushBackForce;
        Rigidbody2D pushRB = pushedObject.gameObject.GetComponent<Rigidbody2D> ();
        pushRB.velocity = Vector2.zero;
        pushRB.AddForce (pushDirection, ForceMode2D.Impulse);
    }
}
