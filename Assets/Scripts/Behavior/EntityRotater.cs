using UnityEngine;
using System.Collections;

public class EntityRotater : MonoBehaviour
{
	public float xRotation = 10f;
	public float yRotation = 10f;
	public float zRotation = 10f;

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void FixedUpdate ()
	{
		transform.Rotate (xRotation, yRotation, zRotation);
	}
}
