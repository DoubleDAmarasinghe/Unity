using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin_Collector : MonoBehaviour {

	private void OnTriggerEnter2D(Collider2D other)
{
	if(other.gameObject.CompareTag("coin"))
	{
		Destroy(other.gameObject);
	}
}
}
