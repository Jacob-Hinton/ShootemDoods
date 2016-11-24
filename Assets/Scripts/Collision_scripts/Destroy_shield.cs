using UnityEngine;
using System.Collections;

public class Destroy_shield : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D col) {

		ContactPoint2D contact = col.contacts[0];
		Quaternion rot = Quaternion.FromToRotation(Vector3.up, contact.normal);
		Vector3 pos = contact.point;
		Destroy(gameObject);
	}
}
