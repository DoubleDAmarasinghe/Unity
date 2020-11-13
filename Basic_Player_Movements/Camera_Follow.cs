using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Follow : MonoBehaviour {
public Transform robot;

void FixedUpdate()
{
	transform.position = new Vector3(robot.position.x, robot.position.y, transform.position.z);
}
}
