using UnityEngine;
using System.Collections;

public class CameraPan : MonoBehaviour {


	// Use this for initialization
	void Start () {

	}
	//Public vars
	public int TiltSpeed = 50;
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.W)==true){
			transform.Rotate(new Vector3(TiltSpeed * Time.deltaTime,0,0)); //Camera rotates down
		}
	if (Input.GetKey(KeyCode.S) == true){
			transform.Rotate(new Vector3(-TiltSpeed * Time.deltaTime,0,0)); //Camera rotates up
		}
	if (Input.GetKey (KeyCode.D) == true) {
			transform.Rotate(new Vector3(0,TiltSpeed * Time.deltaTime,0));
		}
	if (Input.GetKey (KeyCode.A) == true) {
			transform.Rotate(new Vector3(0,-TiltSpeed * Time.deltaTime,0));
	}
	if (Input.GetKey (KeyCode.E) == true) {
			transform.Rotate(new Vector3(0,0,-TiltSpeed * Time.deltaTime));
		}
		if (Input.GetKey (KeyCode.Q) == true) {
			transform.Rotate(new Vector3(0,0,TiltSpeed * Time.deltaTime));
		}
		}
}