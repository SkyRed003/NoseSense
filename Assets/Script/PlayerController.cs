using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
  private Rigidbody2D characterBody;

  private float ScreenWidth;
  public float moveSpeed = 300;
  public GameObject character;
  private bool isJumping => characterBody.velocity.y > 0.01f;
 

  bool facingRight = true;

  public void Jump(float force) {
    if(isJumping) return;

    var velocity = characterBody.velocity;
    velocity.y = force;
    characterBody.velocity = velocity;
  }

  void Start() {

       ScreenWidth = Screen.width;
        characterBody = character.GetComponent<Rigidbody2D>();
  }

   void Update() {

    
    float move = Input.GetAxisRaw("Horizontal");
    characterBody.velocity = new Vector2(move * moveSpeed, characterBody.velocity.y);



    if (move < 0 && facingRight) {

        flip();
    }
     if (move > 0 && !facingRight) {

        flip();
    }

    
   }
    void FixedUpdate() {
        #if UNITY_EDITOR
        RunCharacter(Input.GetAxisRaw("Horizontal"));
        #endif
    }
    private void RunCharacter(float horizontalInput) {
        characterBody.AddForce(new Vector2(horizontalInput * moveSpeed * Time.deltaTime, 0));
    }

    void flip() {

        facingRight = !facingRight;
        transform.Rotate(0f, 180, 0f);
    }

   
}
