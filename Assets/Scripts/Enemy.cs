using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float currentHealth, maxHealth;
    public HealthBarBehavior enemyHealthBar;
    [HideInInspector] public bool enemyTargetted;

    void OnMouseDown()
    {
        enemyTargetted = true;  
    }

    
    
    
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        enemyHealthBar.SetHealth(currentHealth, maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeHit(float damage)
    {
        currentHealth -= damage;
        enemyHealthBar.SetHealth(currentHealth, maxHealth);

        if (currentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }    
}
