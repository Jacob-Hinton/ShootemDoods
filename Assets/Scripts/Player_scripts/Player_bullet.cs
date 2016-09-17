using UnityEngine;
using System.Collections;

public class Player_bullet : MonoBehaviour {

	public Rigidbody2D projectile;
	int speed = 20;



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {



			// Instantiate the projectile at the position and rotation of this transform
			Rigidbody2D clone;
			clone = Instantiate(projectile, transform.position + new Vector3(0.5F,0,0), transform.rotation) as Rigidbody2D;

			clone.velocity = transform.TransformDirection(new Vector3(speed, 0,0));

			//transform.position += Vector3.right * speed * Time.deltaTime;
		}
	}
}
