using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchProjectile : MonoBehaviour
{

    public GameObject projectile;
    public Enemy enemy;
    public PlayerStatus playerStats;
    public InputTargetting input;
    
    public bool bulletLaunched;
    public float attackDelay;
    
    // Start is called before the first frame update
    void Start()
    {
        attackDelay = playerStats.attackDelay;
        input = gameObject.GetComponent<InputTargetting>();
    }

    // Update is called once per frame
    void Update()
    {
        
        
        /*if (enemy.enemyTargetted == true)*/ // When an enemy is clicked/touched, we proceed to launch projectile.
        if (input.enemyTargetted)
        {
            GameObject player = GameObject.FindGameObjectWithTag("Player");
            player.GetComponent<PlayerController>().enabled = false; // Restrict movement while in attack animation
            
            bulletLaunched = true;
            
            if (attackDelay > 0f) // For Attack Delay (Attack Point).
            {
                
                attackDelay -= Time.deltaTime;
                if (attackDelay <= 0f)
                {
                    GameObject bullet = Instantiate(projectile, transform.position, transform.rotation);
                    bullet.GetComponent<PlayerBullet>().targetReceive(enemy.transform.position);
                    input.enemyTargetted = false;
                    player.GetComponent<PlayerController>().enabled = true;
                    attackDelay = playerStats.attackDelay; // Resets the Attack Delay
                }
            }
        }
    }

    private void FixedUpdate()
    {
        
    }
}
            
            
            
            
            
                
