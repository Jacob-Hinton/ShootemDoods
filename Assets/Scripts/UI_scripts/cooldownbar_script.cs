using UnityEngine;
using System.Collections;
using UnityEngine.UI;

/****************************************************************************************/
/*
/* FILE NAME: cooldownbar_script
/*
/* DESCRIPTION: dictates the activities of the special power cooldown bar
/*
/*
/* DATE     BY     	DESCRIPTION
/* ======== ======= =============
/* 11/24/16	Jacob	created script
 * 11/25/16 Brandon decreased cooldown time by half
/*
/*
/****************************************************************************************/

public class cooldownbar_script : MonoBehaviour {

	public bool cooldowncomplete;
	public bool numerationbegan;
	public Sprite Sprite0;
	public Sprite Sprite1;
	public Sprite Sprite2;
	public Sprite Sprite3;
	public Sprite Sprite4;
	public Sprite Sprite5;
	Image img;
	// Use this for initialization
	void Start () {
		cooldowncomplete = true;
		numerationbegan = false;
		img = GetComponent<Image> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (!cooldowncomplete) {
			if (!numerationbegan) {
				Debug.Log ("BOB");
				StartCoroutine ("cooldown");
			}
		}
	}

	public IEnumerator cooldown() {
		numerationbegan = true;
		img.sprite = Sprite0;
		yield return new WaitForSeconds (.25f);
		img.sprite = Sprite1;
		yield return new WaitForSeconds (.25f);
		img.sprite = Sprite2;
		yield return new WaitForSeconds (.25f);
		img.sprite = Sprite3;
		yield return new WaitForSeconds (.25f);
		img.sprite = Sprite4;
		yield return new WaitForSeconds (.25f);
		img.sprite = Sprite5;
		cooldowncomplete = true;
		numerationbegan = false;
	}
}
