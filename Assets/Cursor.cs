using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cursor : MonoBehaviour {

    CameraRaycaster camRay;

	// Use this for initialization
	void Start () {
        camRay = GetComponent<CameraRaycaster>();
	}
	
	// Update is called once per frame
	void Update () {
       
	}
}
