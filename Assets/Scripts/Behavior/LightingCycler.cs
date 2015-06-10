using UnityEngine;
using System.Collections;

public class LightingCycler : MonoBehaviour
{
	public float maximumIntensity;
	public float minimumIntensity;
	private Light light;
	private int direction = 1;

	// Use this for initialization
	void Start ()
	{
		this.light = GetComponent<Light> ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		float target;
		if (direction == 1) {
			target = maximumIntensity;
		} else {
			target = minimumIntensity;
		}

		this.light.intensity = Mathf.Clamp (Mathf.Lerp (this.light.intensity, target, Time.deltaTime), minimumIntensity, maximumIntensity);
		float roundedIntensity = (float)decimal.Round ((decimal)this.light.intensity, 2, System.MidpointRounding.AwayFromZero);
		if (roundedIntensity <= minimumIntensity) {
			direction = 1;
		} else if (roundedIntensity >= maximumIntensity) {
			direction = -1;
		}
		Debug.Log ("Intensity: " + roundedIntensity + ", Direction: " + direction + ", Range: " + minimumIntensity + " => " + maximumIntensity);
	}
}
