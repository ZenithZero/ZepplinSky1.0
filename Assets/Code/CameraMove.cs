using UnityEngine;
using System.Collections;

public class CameraMove : MonoBehaviour {
	public static bool GunView = false;
	public float oldX;
	public float oldY;
	public float oldZ;
	void Start () {

	}
	//variables modified via inspector
	public float speed = 7.0f;
	public float TiltSpeed = 50;

	 void Update()
	 {	

		if (Input.GetKey (KeyCode.V) && !GunView) {
			GunView = true;
			transform.position = new Vector3(ZeplinMovementControl.ZepplinPos.x, ZeplinMovementControl.ZepplinPos.y-5, ZeplinMovementControl.ZepplinPos.z);
		} 
		else if (Input.GetKey (KeyCode.B) && GunView) {
			GunView = false;
			transform.position = new Vector3(ZeplinMovementControl.ZepplinPos.x, ZeplinMovementControl.ZepplinPos.y, ZeplinMovementControl.ZepplinPos.z+5);
			transform.rotation = new Quaternion(0,180,0,0);
		}
		if (!GunView) {

			if (Input.GetKey (KeyCode.RightArrow)) { //&& transform.position.x < right_limit) { //move right
				transform.Translate (new Vector3 (speed * Time.deltaTime, 0, 0));
			}
			if (Input.GetKey (KeyCode.LeftArrow)) { //&& transform.position.x > left_limit) { //move left
				transform.Translate (new Vector3 (-speed * Time.deltaTime, 0, 0));
			}
			if (Input.GetKey (KeyCode.DownArrow)) { //&& transform.position.z > down_limit) { //move down
				transform.Translate (new Vector3 (0, 0, -speed * Time.deltaTime));
			}
			if (Input.GetKey (KeyCode.UpArrow)) { //&& transform.position.z < up_limit) { //move up
				transform.Translate (new Vector3 (0, 0, speed * Time.deltaTime));
			}
			if (Input.GetKey (KeyCode.W) == true) {
				transform.Rotate (new Vector3 (TiltSpeed * Time.deltaTime, 0, 0)); //Camera rotates down
			}
			if (Input.GetKey (KeyCode.S) == true) {
				transform.Rotate (new Vector3 (-TiltSpeed * Time.deltaTime, 0, 0)); //Camera rotates up
			}
			if (Input.GetKey (KeyCode.D) == true) {
				transform.Rotate (new Vector3 (0, TiltSpeed * Time.deltaTime, 0));
			}
			if (Input.GetKey (KeyCode.A) == true) {
				transform.Rotate (new Vector3 (0, -TiltSpeed * Time.deltaTime, 0));
			}
			if (Input.GetKey (KeyCode.E) == true) {
				transform.Rotate (new Vector3 (0, 0, -TiltSpeed * Time.deltaTime));
			}
			if (Input.GetKey (KeyCode.Q) == true) {
				transform.Rotate (new Vector3 (0, 0, TiltSpeed * Time.deltaTime));
			}
		} else {
			transform.rotation = (new Quaternion(Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z,0));


		}
	}
}

