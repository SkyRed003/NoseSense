using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
  [SerializeField] private Rigidbody2D myRigidbody;

  private float ScreenWidth;
  public float moveSpeed = 300;
  public GameObject character;
  private bool isJumping => myRigidbody.velocity.y > 0.01f;

  public void Jump(float force) {
    if(isJumping) return;

    var velocity = myRigidbody.velocity;
    velocity.y = force;
    myRigidbody.velocity = velocity;
  }

  void Start() {

       ScreenWidth = Screen.width;
        myRigidbody = character.GetComponent<Rigidbody2D>();
  }

   void Update() {

      int i = 0;

        while (i < Input.touchCount) {
            if (Input.GetTouch (i).position.x > ScreenWidth / 2) {
                RunCharacter (1.0f);
            }
            if (Input.GetTouch (i).position.x < ScreenWidth / 2) {
                RunCharacter (-1.0f);
            }
            ++i;
        }
   }
    void FixedUpdate() {
        #if UNITY_EDITOR
        RunCharacter(Input.GetAxis("Horizontal"));
        #endif
    }
    private void RunCharacter(float horizontalInput) {
        myRigidbody.AddForce(new Vector2(horizontalInput * moveSpeed * Time.deltaTime, 0));
    }
}
