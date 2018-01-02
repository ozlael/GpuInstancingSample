using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayInfo : MonoBehaviour {

	[SerializeField]
	Text textFPS;
	[SerializeField]
	Text textDevice;

	float frames = 0f;
	float timeElap = 0f;

	void Start() {
		textDevice.text = "" + SystemInfo.graphicsDeviceName + ", " + SystemInfo.graphicsDeviceVersion;
	}

	void Update() {
		frames++;
		timeElap += Time.unscaledDeltaTime;
		if (timeElap > 1f) {
			timeElap -= 1f;
			UpdateText ();
			frames =0;
		}
	}

	void UpdateText() {
		textFPS.text = string.Format (
			"FPS : {0}, FrameTime : {1:F2} ms",
			frames, Time.unscaledDeltaTime * 1000.0f);
	}
}
