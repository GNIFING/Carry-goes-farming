using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputTargetting : MonoBehaviour
{
    RaycastHit hit;
    public LaunchProjectile launch;
    public bool enemyTargetted;


    void Start()
    {
        launch = gameObject.GetComponent<LaunchProjectile>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("LM is clicked");

            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, Mathf.Infinity))
            {
                Debug.Log("Raycast initiated");

                if (hit.collider.GetComponent<Targetable>() != null)
                {
                    if (hit.collider.gameObject.CompareTag("Enemy"))
                    {

                        Debug.Log("Enemy Found with Raycast");
                        launch.enemy = hit.collider.GetComponent<Enemy>();
                        enemyTargetted = true;
                        
                    }
                }
                else if (hit.collider.GetComponent<Targetable>() == null)
                {
                    launch.GetComponent<LaunchProjectile>().enemy = null;
                }
            }
        }
    }
}
