using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovemenPlayer : MonoBehaviour
{

    InputSystem controls;

    private float horizontal;
    public float speed = 8f;
    private bool isFacingRight = true;
    private bool isJumping => rb.velocity.y > 0.01f;
    float direction = 0;

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;

    void Awake () {

        controls = new InputSystem();

        controls.Enable();

        controls.Land.Movement.performed += ctx => {

            direction = ctx.ReadValue<float>();
        };
    }
    
   
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");

        Flip();
        
    }

     private void FixedUpdate() {

        rb.velocity = new Vector2(direction * speed * Time.deltaTime, rb.velocity.y);
    }

    private void Flip() {
          if (isFacingRight && direction < 0f || !isFacingRight && direction  > 0f) {

            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }

    public void Jump(float force) {
    if(isJumping) return;

    var velocity = rb.velocity;
    velocity.y = force;
    rb.velocity = velocity;
  }

  private void OnEnable() {
    controls.Enable();
  }

  private void OnDisable() {
    controls.Disable();
  }

    
}
