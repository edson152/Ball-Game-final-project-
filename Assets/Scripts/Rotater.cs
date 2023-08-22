using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Rotater : MonoBehaviour {

	private Vector3 rotation = new Vector3(
		15, 30, 45
	);

	void Update () {
		transform.Rotate(rotation * Time.deltaTime);
	}
}
