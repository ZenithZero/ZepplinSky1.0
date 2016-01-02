using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class HelpPanelHide : MonoBehaviour {
	public Image HelpPanel;
	public bool HelpPanelState = true;
	// Use this for initialization
	void Start () {
		HelpPanel = GetComponent<Image> ();
		HelpPanel.gameObject.SetActive (false);
	}

	public void ToggelHelpPanel(){
		if (HelpPanelState == false) {
			HelpPanelState = true;
		} else {
			HelpPanelState = false;
		}

	}
	// Update is called once per frame
	void Update () {
		HelpPanel.gameObject.SetActive (HelpPanelState);
	}
}
