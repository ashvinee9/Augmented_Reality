﻿using UnityEngine;
using System.Collections;

public class RotatingItem2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(new Vector3(Time.deltaTime*500, 0, 0));
	
	}
}
