using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enemyHeath : MonoBehaviour
{

    public float maxHealth;
    float currentHealth;
    // Start is called before the first frame update
    // bien de tao hieu ung khi enemy die
    public GameObject enemyHealthEF;
    //khai bao cac bien de tao thanh mau cho enemy
    public Slider enemyHealthSlider;
    // khai bao cac bien khi enemy chet se roi ra cuc mau trai tim

    public bool drop;
    public GameObject theDrop;

    void Start()
    {
        currentHealth = maxHealth;
        enemyHealthSlider.maxValue = maxHealth;
        enemyHealthSlider.value = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addDamge(float damage)
    {
        enemyHealthSlider.gameObject.SetActive(true);
        currentHealth = currentHealth - damage;
        enemyHealthSlider.value = currentHealth;
        if (currentHealth <= 0)
            makeDead();
            
    }
     void makeDead()
    {
        gameObject.SetActive(false);
        Instantiate(enemyHealthEF, transform.position, transform.rotation);
        //chuc nang roi ra cuc mau sau khi quai vat chet
        if (drop)
        {
            Instantiate(theDrop, transform.position, transform.rotation);
        }
    }

}
