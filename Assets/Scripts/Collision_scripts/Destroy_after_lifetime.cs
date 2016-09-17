using UnityEngine;
using System.Collections;

public class Destroy_after_lifetime : MonoBehaviour {
	public float lifetime;

	// Use this for initialization
	void Start () {
		Destroy (gameObject, lifetime);
	}

	// Update is called once per frame
	void Update () {
		Destroy (gameObject, lifetime);
	}
}
