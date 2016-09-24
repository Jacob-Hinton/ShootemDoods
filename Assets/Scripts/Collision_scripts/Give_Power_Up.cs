using UnityEngine;
using System.Collections;

public class Give_Power_Up : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D col) {
		if (col.gameObject.tag == "Player") {
			// ContactPoint2D contact = col.contacts[0];
			if(this.gameObject.tag == "red_power_up")
				col.gameObject.GetComponent<Player_control>().held_power_ups.Push('r');
			// Quaternion rot = Quaternion.FromToRotation(Vector3.up, contact.normal);
			// Vector3 pos = contact.point;
			// Instantiate(, pos, rot);
			Destroy(this.gameObject);
		}
	}
}
