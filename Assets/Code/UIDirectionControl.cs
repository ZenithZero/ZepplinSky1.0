using UnityEngine;
using System.Collections;

public class UIDirectionControl : MonoBehaviour {
	public static float TurnAmu;
	// Use this for initialization
	void Start () {
	
	}
	void Update () {
	if (Input.GetKey (KeyCode.L) == true) {
			transform.Rotate(new Vector3(0,0,10*-Time.deltaTime));
			TurnAmu -= Time.deltaTime*10;
		}
	else if (Input.GetKey (KeyCode.J) == true) {
			transform.Rotate(new Vector3(0,0,10*Time.deltaTime));
			TurnAmu += Time.deltaTime*10;
		
		}
		}
	}

