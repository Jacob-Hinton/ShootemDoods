using UnityEngine;
using System.Collections;

public class Spawn_powerup : MonoBehaviour {
	public Transform red_power_up;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Spawn(){
		if(gameObject.tag == "red_enemy"){
			Instantiate(red_power_up, transform.position, Quaternion.identity);
		}
	}
}
