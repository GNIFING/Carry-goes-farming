using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    public Enemy enemy;
    private float bulletDamage = 1f;
    private float launchVelocity = 10f;
    private Vector2 attackTarget;
    private bool startAttack;

    // Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
        if (startAttack)
        {
            transform.position = Vector2.MoveTowards(transform.position, attackTarget, launchVelocity * Time.deltaTime);
        }   
    }    

    public void targetReceive(Vector2 target)
    {
        attackTarget = target;
        startAttack = true;
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            //Debug.Log("Reached Enemy!");
            Enemy targettedEnemy = collision.GetComponent<Enemy>();
            //targettedEnemy.currentHealth -= bulletDamage;
            //if (targettedEnemy.currentHealth < bulletDamage)
            //{
            //    Destroy(collision.gameObject);
            //}
            targettedEnemy.TakeHit(bulletDamage);
            Destroy(gameObject);
        }

    }
}
            
