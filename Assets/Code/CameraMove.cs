using UnityEngine;
using System.Collections;

public class CameraMove : MonoBehaviour {

	void Start () {

	}
	//variables modified via inspector
	public float speed = 7.0f;


	 void Update()
	 {	
				
						if (Input.GetKey (KeyCode.RightArrow)){ //&& transform.position.x < right_limit) { //move right
								transform.Translate (new Vector3 (speed * Time.deltaTime, 0, 0));
						}
						if (Input.GetKey (KeyCode.LeftArrow)){ //&& transform.position.x > left_limit) { //move left
								transform.Translate (new Vector3 (-speed * Time.deltaTime, 0, 0));
						}
						if (Input.GetKey (KeyCode.DownArrow)){ //&& transform.position.z > down_limit) { //move down
								transform.Translate (new Vector3 (0, 0, -speed * Time.deltaTime));
						}
						if (Input.GetKey (KeyCode.UpArrow)){ //&& transform.position.z < up_limit) { //move up
								transform.Translate (new Vector3 (0, 0, speed * Time.deltaTime));
						}
				}
		}

