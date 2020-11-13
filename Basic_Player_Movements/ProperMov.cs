using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProperMov : MonoBehaviour {

public float playerspeed;
public float jumpspeed;

private bool isjumping;
private float move;
private Rigidbody2D rb;
private Animator anim;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();	
		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		move = Input.GetAxis("Horizontal");
		rb.velocity = new Vector2(move * playerspeed, rb.velocity.y);
		if(move < 0)
		{
			transform.eulerAngles = new Vector3(0, 180, 0);
		}
		else if(move > 0)
		{
			transform.eulerAngles = new Vector3(0, 0, 0);
		}
		if(Input.GetButtonDown("Jump") && !isjumping)
		{
			rb.AddForce(new Vector2(rb.velocity.x, jumpspeed));
			isjumping = true;
		}
		RunAnimations();
	}

	private void OnCollisionEnter2D(Collision2D other)
	{
		if(other.gameObject.CompareTag("ground"))
		{
			isjumping = false;
		}
	}
	void RunAnimations()
	{
		anim.SetFloat("movement", Mathf.Abs(move));
		anim.SetBool("jumpinj", isjumping);
	}
}
