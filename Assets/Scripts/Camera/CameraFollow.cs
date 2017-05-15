using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

    public Transform player;
    public float smoothing = 5f;

    private Vector3 offset;

	// Use this for initialization
	void Awake () {
        offset = transform.position - player.position;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        Vector3 camPos = player.position + offset;
        transform.position = Vector3.Lerp(transform.position, camPos, smoothing);
	}
}
