using UnityEngine;
using System.Collections;

public class Camera_scrolling : MonoBehaviour {
	private float cameraScrollSpeed = Ambient_scrolling.ambientScrollSpeed;
	private Vector3 pos;
	private float space = Ambient_scrolling.ambientScrollSpace;
	// Use this for initialization
	void Start () {
		pos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		pos.x += space;
		transform.position = Vector3.MoveTowards(transform.position, pos, cameraScrollSpeed * Time.deltaTime);
	}
}
