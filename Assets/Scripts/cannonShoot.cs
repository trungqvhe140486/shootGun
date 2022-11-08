using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cannonShoot : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject theBom;
    public Transform shootForm;
    public float shootTime;

    float nextShoot = 0f;

    Animator cannonAnim;

    void Awake()
    {
        cannonAnim = GetComponentInChildren<Animator>();   
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerStay2D(Collider2D other)
    {
        if(other.tag == "Player" && Time.time > nextShoot)
        {
            nextShoot = Time.time + shootTime;
            Instantiate(theBom, shootForm.position, Quaternion.identity);
            cannonAnim.SetTrigger("CannonShoot");
        }
    }

}
