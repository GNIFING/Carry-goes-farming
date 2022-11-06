using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void CheckAllEnemyDead()
    {
        GameObject[] enemys = GameObject.FindGameObjectsWithTag("Enemy");
        if (enemys.Length == 0)
        {
            Debug.Log("All enemies have been eliminated.");
        }
        else Debug.Log("Number of enemies is " + enemys.Length);
    }
}
