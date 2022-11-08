using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerHealth : MonoBehaviour
{
    public float maxhealth;
    float currentHealth;
    // Start is called before the first frame update

    public GameObject bloodEffect;

    // khai bao cac bien UI
    public Slider playerHealthSlider;

    void Start()
    {
        currentHealth = maxhealth;

        playerHealthSlider.maxValue = maxhealth;

        playerHealthSlider.value = maxhealth;


             
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     public void addDamage(float damage)
    {
        if (damage <= 0)
            return;
        currentHealth -= damage;

        playerHealthSlider.value = currentHealth;

        if (currentHealth <= 0)
            makeDead();
    }
    // TAO RA CHUC nang hoi mau khi an dc mau

    public void addHealth(float healthAmount)
    {
        currentHealth += healthAmount;
        if (currentHealth > maxhealth)
            currentHealth = maxhealth;
        playerHealthSlider.value = currentHealth;
    }
    void makeDead()
    {
        Instantiate(bloodEffect, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
