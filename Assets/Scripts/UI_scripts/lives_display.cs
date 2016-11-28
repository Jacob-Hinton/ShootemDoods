using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class lives_display : MonoBehaviour {

	public Sprite[] sprites = new Sprite[4];
	Image img;
	// Use this for initialization
	void Start () {
		img = GetComponent<Image> ();
	}
	
	// Update is called once per frame
	void Update () {
		img.sprite = sprites [life_counter.lives];
	}
}
