using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownTrigger : MonoBehaviour
{
    public GameObject player;
    public GameObject button;

    void Start()
    {
        
    }
    
    void Update()
    {
        Debug.Log(player.GetComponent<Rigidbody2D>().velocity.y);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("entered");
        if (player.GetComponent<Rigidbody2D>().velocity.y <= -5.0f)
        {
            //Press button.
            Debug.Log("pressed");
            button.transform.Translate(0.0f, -0.2f, 0.0f);
        }
        else
        {
            //Physics.IgnoreCollision(player.GetComponent<BoxCollider2D>(), button.GetComponent<BoxCollider2D>());
        }
    }
}
