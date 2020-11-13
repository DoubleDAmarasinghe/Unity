using UnityEngine;
using System.Collections;
public class MovwithJump : MonoBehaviour {
  public float speed = 5f;
  public float jumpSpeed = 8f;
  private float movement = 0f;
  private Rigidbody2D rigidBody;
  // Use this for initialization
  void Start () {
    rigidBody = GetComponent<Rigidbody2D> ();
  }
  
  // Update is called once per frame
  void Update () {


    movement = Input.GetAxis ("Horizontal");
    if (movement > 0f) {
      rigidBody.velocity = new Vector2 (movement * speed, rigidBody.velocity.y);
    }
    else if (movement < 0f) {
      rigidBody.velocity = new Vector2 (movement * speed, rigidBody.velocity.y);
    } 
    else {
      rigidBody.velocity = new Vector2 (0,rigidBody.velocity.y);
    }
    if(Input.GetButtonDown ("Jump")){
      rigidBody.velocity = new Vector2(rigidBody.velocity.x,jumpSpeed);
    }
  }

  private void OnTriggerEnter2D(Collider2D other)
{
	if(other.gameObject.CompareTag("coins"))
	{
		Destroy(other.gameObject);
	}
}

}