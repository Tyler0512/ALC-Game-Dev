using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    [Header("Enemy Stats")]
    public float moveSpeed;
    public Vector3 moveOffset; //Enemy direction
    private Vector3 startPos;
    private Vector3 targetPos;
    private int turn = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPos = transform.position;
        targetPos = startPos;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, targetPos, moveSpeed * Time.deltaTime);

        //Checks if we are at the target position
        if (transform.position == targetPos)
        {
            if (turn == 0)
            {
                transform.rotation = Quaternion.Euler(0, 180, 0);
                turn = 1;
            }

            else
            {
                transform.rotation = Quaternion.Euler(0, 0, 0);
                turn = 0;
            }
            
            // If the target position equals the start position, add an offset.
            if (targetPos == startPos)
            {
                targetPos = startPos + moveOffset;
                
            }
            // If the target position does not equal the start position, return to start position.
            else
            {
                targetPos = startPos;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            //Restart the level
            collision.GetComponent<PlayerController2D>().GameOver();
        }
    }
    
    private void OnDrawGizmos()
    {
        Vector3 from;
        Vector3 to;

        if (Application.isPlaying)
        {
            from = startPos;
        }
        else
        {
            from = transform.position;
        }

        to = from + moveOffset;

        Gizmos.color = Color.red;
        Gizmos.DrawLine(from, to);
        Gizmos.DrawWireSphere(to, 0.2f);

    }


}
