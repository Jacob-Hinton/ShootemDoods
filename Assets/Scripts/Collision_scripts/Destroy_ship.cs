using UnityEngine;
using System.Collections;
using System.Linq;

public class Destroy_ship : MonoBehaviour {

	private Player_control pc;
	public Transform explosionPrefab;

	void OnCollisionEnter2D(Collision2D col) {
		pc = col.gameObject.GetComponent<Player_control>();
		if (col.gameObject.tag == "Player" && pc.hitframes==false) {
			if(Enumerable.SequenceEqual(pc.poweruparray, new int[3])){
				ContactPoint2D contact = col.contacts[0];
				Quaternion rot = Quaternion.FromToRotation(Vector3.up, contact.normal);
				Vector3 pos = contact.point;
				Instantiate(explosionPrefab, pos, rot);
				Destroy(col.gameObject);
			}
			else{
				pc.LosePowerUp();
			}
		}
	}
	void OnCollisionStay2D(Collision2D col){
		if (col.gameObject.tag == "Player" && pc.hitframes==false) {
			ContactPoint2D contact = col.contacts[0];
			Quaternion rot = Quaternion.FromToRotation(Vector3.up, contact.normal);
			Vector3 pos = contact.point;
			Instantiate(explosionPrefab, pos, rot);
			Destroy(col.gameObject);
		}
	}
}
