using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBoundary : MonoBehaviour {

	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -8f, 8f),
            Mathf.Clamp(transform.position.y, -3f, 2.5f), transform.position.z);
	}
}
