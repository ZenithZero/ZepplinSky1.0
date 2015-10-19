using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class ThrottleControl : MonoBehaviour {
	public Slider ThrottleSlider;
	public static float Throttle;
	// Use this for initialization
	void Start () {
		ThrottleSlider = gameObject.GetComponent<Slider> ();
	}
	
	// Update is called once per frame
	void Update () {
		Throttle = ThrottleSlider.value;
	}
}
