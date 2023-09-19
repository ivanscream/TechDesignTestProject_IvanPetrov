using System.Collections;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;

    private Rigidbody2D rb;
    private Collider2D col;
    private Vector2 movement;
    private bool facingRight = true;

    private Animator animator;
  

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        col = GetComponent<Collider2D>();
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        
       movement.x = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2 (movement.x * moveSpeed, rb.velocity.y);

        if(!facingRight && movement.x > 0)
            PlayerFlip();
        else if(facingRight && movement.x < 0)
            PlayerFlip();


        AnimControl();

    }

    private void FixedUpdate()
    {
        float moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveInput * moveSpeed, rb.velocity.y);
    }
    
    void PlayerFlip() {
        facingRight = !facingRight;
        var transform1 = transform;
        Vector3 scale = transform1.localScale;
        scale.x *= -1;
        transform1.localScale = scale;
    }
    
    void AnimControl()
    {
        
        animator.SetFloat("speed", movement.sqrMagnitude);

    }

    

    
}

