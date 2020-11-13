using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerUpDownLeftRight : MonoBehaviour {

	// Use this for initialization
	private float moveSpeed = 4f;
 
 // Use this for initialization
 void Start () {
 
 }
 
 // Update is called once per frame
 void Update () {
     Vector3 playerPos = transform.position;
     
    if(Input.GetKey("left"))
         transform.position -= Vector3.right * moveSpeed * Time.deltaTime;
 
    if(Input.GetKey("right"))
         transform.position += Vector3.right * moveSpeed * Time.deltaTime;
     
    if(Input.GetKey("up"))
         transform.position += Vector3.up * moveSpeed * Time.deltaTime;    
     
    if(Input.GetKey("down"))
         transform.position -= Vector3.up * moveSpeed * Time.deltaTime;
     
    if(playerPos.x > Screen.width){
         playerPos.x = Screen.width;
         transform.position = playerPos;    
 
     }
 }    
}
