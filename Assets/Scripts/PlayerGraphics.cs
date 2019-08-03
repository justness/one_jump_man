using System;
using UnityEngine;

public class PlayerGraphics : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    private Animator animator;
    private PlayerController playerController;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        playerController = GetComponent<PlayerController>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        spriteRenderer.flipX = !(playerController.FacingRight);
        animator.SetBool("isWalking", (Math.Abs(playerController.rb.velocity.x) > 0.3f) && playerController.Grounded);
    }
}
