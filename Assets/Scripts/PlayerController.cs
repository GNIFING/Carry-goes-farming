using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private bool isWalking;
    [SerializeField]
    private float speed = 1;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isWalking)
        {
            Debug.Log("player is walking");
            PlayerWalking();
        }
    }

    void PlayerWalking()
    {
        transform.Translate(speed * Time.deltaTime , 0, 0);
    }

    public void SetWalking()
    {
        isWalking = true;
    }
}
