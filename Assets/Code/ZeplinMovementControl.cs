using UnityEngine;
using System.Collections;

public class ZeplinMovementControl : MonoBehaviour {
	public float ForwardScaler;
	public float TurnPos;
	public bool Hover = false;
	public Rigidbody Zeplin;
	private float ForwardThrottle;
	private float error;
	void Start () {
		//Zeplin = GetComponent<Rigidbody> ();
	}
	public void HoverStateChange(){
		if (Hover == false) {
			Hover = true;
		} else {
			Hover = false;
		}
	}
	// Update is called once per frame
	void Update () {

		Physics.gravity = new Vector3 (0, -1.0F, 0);
		error = ThrottleControl.Throttle-ForwardThrottle;
		ForwardThrottle += (error * 0.002f);

		//GetComponent<Rigidbody>().velocity = new Vector3 (ThrottleControl.Throttle * 50, 0, 0);
		//Zeplin.AddForce(new Vector3(ThrottleControl.Throttle*10,0,0),ForceMode.Acceleration);
			transform.Translate (new Vector3(-ForwardThrottle*100*Time.deltaTime,0,0)); 
		if (AltitudeControl.Altitude > 0 && Hover == false) {
			transform.Translate (new Vector3 (0,0, 5* AltitudeControl.Altitude * Time.deltaTime));
		} else if (AltitudeControl.Altitude < 0 && Hover == false) {
			transform.Translate (new Vector3(0,0,5*AltitudeControl.Altitude*Time.deltaTime));
		}
			if (UIDirectionControl.TurnAmu > TurnPos) {
			transform.Rotate (new Vector3 (0, 0, -4 * Time.deltaTime));
			TurnPos += 4 * Time.deltaTime;
		} else if (UIDirectionControl.TurnAmu < TurnPos) {
			transform.Rotate (new Vector3 (0,0,4*Time.deltaTime));
			TurnPos -= 4 * Time.deltaTime;
		}
	
			      }
			                    
}
