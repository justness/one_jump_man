using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovementController : MonoBehaviour
{
    public Vector2 targetPosition;
    public float linger;
    public float speed;

    private Vector2 startPosition;
    private bool forward;
    private Rigidbody2D rb;
    private float canMove;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = new Vector2(transform.position.x, transform.position.y);
        rb = GetComponent<Rigidbody2D>();
        forward = true;
        canMove = 0;
    }

    // Update is called once per frame
    void Update()
    {
        float step = speed * Time.deltaTime;

        if (transform.position.y >= targetPosition.y)
        {
            if (forward)
            {
                forward = false;
                canMove = Time.time + linger;
            }
        }
        else if (transform.position.y <= startPosition.y)
        {
            if (!forward)
            {
                forward = true;
                canMove = Time.time + linger;
            }
        }

        if (Time.time > canMove)
        {
            if (forward)
            {
                rb.MovePosition(Vector2.MoveTowards(transform.position, targetPosition, step));
            }
            else
            {
                rb.MovePosition(Vector2.MoveTowards(transform.position, startPosition, step));
            }
        }
    }
}
