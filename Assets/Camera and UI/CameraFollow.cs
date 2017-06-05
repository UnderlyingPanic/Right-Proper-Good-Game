using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    private GameObject player;

    public float closestAllowed = 4f;
    public float furthestAllowed = 13f;
    public float zoomIncrement = 1f;

    private Vector3 zoomVector;
    private float distanceFromPlayer;

    // Use this for initialization
    void Start() {
        zoomVector = new Vector3(0, 0, zoomIncrement);
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void Update()
    {
        distanceFromPlayer = Vector3.Distance(player.transform.position, Camera.main.transform.position);
        print(distanceFromPlayer);

        if ((Input.GetAxis("Mouse ScrollWheel") > 0) && (distanceFromPlayer > closestAllowed))
        {
            Camera.main.transform.Translate (zoomVector);
        } else if ((Input.GetAxis("Mouse ScrollWheel")) < 0 && (distanceFromPlayer < furthestAllowed))
        {
            Camera.main.transform.Translate (-zoomVector);
        }
    }

    // Update is called once per frame
 	void LateUpdate () {
        transform.position = player.transform.position;
	}
}
