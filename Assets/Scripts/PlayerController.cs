using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
<<<<<<< HEAD
    private bool isWalking;
    [SerializeField]
    private float speed = 1;
    
=======
    public float moveSpeed = 7f;
    public Rigidbody2D rb;

>>>>>>> fbf8fb4eeeefda1701c52cf170182611ad124d79
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
<<<<<<< HEAD
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
=======
        //float h = Input.GetAxis("Horizontal");
        //float v = Input.GetAxis("Vertical");

        //Vector3 tempVect = new Vector3(h, v, 0);
        //tempVect = tempVect.normalized * moveSpeed * Time.deltaTime;
        //rb.MovePosition(rb.transform.position + tempVect);

        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * moveSpeed * Time.deltaTime;

        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.right * -moveSpeed * Time.deltaTime;

        }

        else if (Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.up * moveSpeed * Time.deltaTime;

        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.up * -moveSpeed * Time.deltaTime;

        }

>>>>>>> fbf8fb4eeeefda1701c52cf170182611ad124d79
    }

    
}