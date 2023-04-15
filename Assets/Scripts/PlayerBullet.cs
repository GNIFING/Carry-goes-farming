using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    public Enemy enemy;
    public PlayerStatus playerStats;
    private float bulletDamage;
    private float launchVelocity = 20f;
    private Vector2 attackTarget;
    private bool startAttack;

    // Start is called before the first frame update
    void Start()
    {
        bulletDamage = playerStats.attackDamage;
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

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            //Debug.Log("Reached Enemy!");
            Enemy targettedEnemy = collision.GetComponent<Enemy>();            
            targettedEnemy.TakeHit(bulletDamage);
            Destroy(gameObject);
        }

    }
}
            
