using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class AltitudeControl : MonoBehaviour {
	public Slider AltSlider;
	public static float Altitude;
	// Use this for initialization
	void Start () {
		AltSlider = gameObject.GetComponent<Slider> ();
	}
	
	// Update is called once per frame
	void Update () {
		Altitude = AltSlider.value;
	}
}
