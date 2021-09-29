using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIPaddle : Paddle
{
   public Rigidbody2D ball;
   private void FixedUpdate()
   {
       if (this.ball.velocity.y > 0.0f)
       {
       
            if(this.ball.position.x > this.transform.position.x)
             {
                _rigidbody.AddForce(Vector2.right * this.speed);
              }
             else if (this.ball.position.x < this.transform.position.x)
             {
                _rigidbody.AddForce(Vector2.left * this.speed);
            }
       }
       else
       {
           if (this.transform.position.x > 0.0f)
           {
               _rigidbody.AddForce(Vector2.right * this.speed);
           }
           else if (this.transform.position.x < 0.0f)
           {
               _rigidbody.AddForce(Vector2.left * this.speed);
           }
       }
   }
}
