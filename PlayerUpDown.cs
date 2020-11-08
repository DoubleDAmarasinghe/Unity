using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerUpDown : MonoBehaviour {
	public float ms;
	public Rigidbody2D rd2;

	// Use this for initialization
	void Start () {
		//transform.position = new Vector3(0, 0, 0);
		ms = 2f;
		rd2 = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		
		/*if(transform.position.y >= 1)
		{
			transform.position = new Vector3(transform.position.x, 2, 0);
		}*/
		
		float moy = Input.GetAxisRaw("Vertical");
		if (moy != 0)
		{
			rd2.velocity = new Vector2(rd2.velocity.x, ms * moy);
		}
	}
}
