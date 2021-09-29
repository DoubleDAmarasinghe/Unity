using UnityEngine;

public class Player_Paddle : Paddle
{
   private Vector2 _direction;
   private void Update()
   {
       if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
       {
           _direction = Vector2.right;
       }
       else if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
       {
           _direction = Vector2.left;
       }
       else
       {
           _direction = Vector2.zero;
       }
   }

   private void FixedUpdate()
   {
       if (_direction.sqrMagnitude != 0)
       {
           _rigidbody.AddForce(_direction * this.speed);
       }
   }
}
