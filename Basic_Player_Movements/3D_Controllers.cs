using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class controllers : MonoBehaviour
{
    float speed = 4;
    float rotSpeed = 100;
    float rot = 0f;
    float gravity = 8;


    Vector3 moveDir = Vector3.zero;


    CharacterController controller;
    Animator anim;




    // Start is called before the first frame update
    void Start()
    {


        controller = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();
    }


    // Update is called once per frame
    void Update()
    {
        Movement();
		GetInput();


        }
		void Movement()
		{
		if (controller.isGrounded)
        {


        if (Input.GetKey(KeyCode.W))
        {
			if (anim.GetBool("shoot") == true)
			{
				return;
			}
			else if (anim.GetBool ("shoot") == false)
		    {
            anim.SetBool("run",true);
			anim.SetInteger("condition", 1);
            moveDir = new Vector3(0, 0, 1);
            moveDir *= speed;
            moveDir = transform.TransformDirection(moveDir);
		    }
		}
            if (Input.GetKeyUp(KeyCode.W))
			{
                anim.SetBool("run",false);
				anim.SetInteger("condition", 0);
            moveDir = new Vector3(0, 0, 0);


			}
		}
            rot += Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime;
            transform.eulerAngles = new Vector3(0, rot, 0);


            moveDir.y -= gravity * Time.deltaTime;
            controller.Move(moveDir * Time.deltaTime);
	    }
		
		void GetInput()
		{
			if (controller.isGrounded)
			{
				if (Input.GetMouseButtonDown (0))
				{
					if(anim.GetBool("run")== true)
					{ anim.SetBool ("run", false);
				      anim.SetInteger("condition", 0);
					}
					if (anim.GetBool("run")== false)
					{
					 Attacking();
					} 
				}
			}
		}
		
		void Attacking()
		
		{
			StartCoroutine (AttackRoutine());
		}
		IEnumerator AttackRoutine()
		{
			anim.SetBool ("shoot", true);
			anim.SetInteger("condition", 2);
			yield return new WaitForSeconds (1);
			anim.SetInteger ("condition", 0);
			anim.SetBool ("shoot", false);
		}
}
		