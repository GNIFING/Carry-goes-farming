using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchProjectile : MonoBehaviour
{

    public GameObject projectile;
    public Enemy enemy;
    public bool bulletLaunched;
    public float attackDelay = 1f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (enemy.enemyTargetted == true) // When an enemy is clicked/touched, we proceed to launch projectile.
        {
            
            bulletLaunched = true;
            
            if (attackDelay > 0f) // For Attack Delay (Attack Point).
            {
                attackDelay -= Time.deltaTime;
                if (attackDelay <= 0f)
                {
                    GameObject bullet = Instantiate(projectile, transform.position, transform.rotation);
                    bullet.GetComponent<PlayerBullet>().targetReceive(enemy.transform.position);
                    enemy.enemyTargetted = false;
                    attackDelay = 1f; // Resets the Attack Delay
                }
            }
        }
    }
}
            
            
            
            
            
                
