using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 30f;
    public bool isFacingRight = true;
    public float smoothingFactor = 0.05f;
    private float horizontalMove = 0f;
    private Animator animator;
    private Rigidbody2D rb;
    private Vector3 velocity = Vector3.zero;


    void Start()
    {
        animator = this.GetComponentInChildren<Animator>();
        rb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxis("Horizontal") * speed;

        // Check for running animation
        if(horizontalMove == 0){
            animator.SetBool("isRunning", false);
        } else {
            animator.SetBool("isRunning", true);
        }
    }

    void FixedUpdate()
    {
		// Move the character by finding the target velocity
		Vector3 targetVelocity = new Vector2(horizontalMove, rb.velocity.y);
		// And then smoothing it out and applying it to the character
		rb.velocity = Vector3.SmoothDamp(rb.velocity, targetVelocity, ref velocity, smoothingFactor);
		// If the input is moving the player right and the player is facing left
        // then we flip it
		if (horizontalMove > 0 && !isFacingRight)
		{
			Flip();
		}
		else if (horizontalMove < 0 && isFacingRight)
		{
			Flip();
		}
    }

    private void Flip ()
    {
		// We change the direction the player is facing
		isFacingRight = !isFacingRight;

        // We could simply Flip using the Sprite Renderer
        // property, however, it wouldn't flip the rest of
        // the components. To fix that, we can just
		// multiply the player's x local scale by -1
		Vector3 newScale = transform.localScale;
		newScale.x *= -1;
		transform.localScale = newScale;
    }
}
