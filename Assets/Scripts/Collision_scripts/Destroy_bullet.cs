using UnityEngine;
using System.Collections;

public class Destroy_bullet : MonoBehaviour {

	public Transform explosionPrefab;


	void OnCollisionEnter2D(Collision2D col) {
		
		ContactPoint2D contact = col.contacts[0];
		Quaternion rot = Quaternion.FromToRotation(Vector3.up, contact.normal);
		Vector3 pos = contact.point;
		Instantiate(explosionPrefab, pos, rot);
		if(col.gameObject.tag == "red_enemy"){
			col.gameObject.GetComponent<Spawn_powerup>().Spawn();
			Destroy(col.gameObject);
		}
		Destroy(gameObject);

		
	}
}
