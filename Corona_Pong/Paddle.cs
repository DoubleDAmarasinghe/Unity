using UnityEngine;

public class Paddle : MonoBehaviour
{
  
  public float speed = 10.0f;
  protected Rigidbody2D _rigidbody;

  private void Awake()
  {
      _rigidbody = GetComponent<Rigidbody2D>();
  }

  public void ResetPosition()
  {
    //_rigidbody.position = new Vector3(_rigidbody.position.x, 0.0f);
    _rigidbody.velocity = Vector3.zero;
  }
}
