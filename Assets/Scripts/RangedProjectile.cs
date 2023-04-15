using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangedProjectile : MonoBehaviour
{

    public GameObject target;
    public PlayerStatus playerStats;

    public bool targetSet;
    public string targetType;
    public float velocity;
    public bool stopProjectile;

    // Start is called before the first frame update
    void Start()
    {
        playerStats = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerStatus>();
    }

    // Update is called once per frame
    void Update()
    {
       if (target)
        {
            if (target == null)
            {
                Destroy(gameObject);
            }

            transform.position = Vector2.MoveTowards(transform.position, target.transform.position, velocity * Time.deltaTime);

            if (!stopProjectile)
            {
                if (Vector2.Distance(transform.position, target.transform.position) <= 0.5f)
                {
                    if (target.CompareTag("Enemy"))
                    {
                        target.GetComponent<Enemy>().currentHealth -= playerStats.attackDamage;
                        stopProjectile = true;
                        Destroy(gameObject);
                    }
                }
            }
        } 
    }
}
                    

