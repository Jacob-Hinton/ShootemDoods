using UnityEngine;
using System.Collections;
using UnityEngine.UI;

/****************************************************************************************/
/*
/* FILE NAME: Gauge_Node
/*
/* DESCRIPTION: this script controls the activity of the nodes in the
 * power up gauge.
/*
/*
/* DATE     BY     			  DESCRIPTION
/* ======== ======= 		  =============
/* 11/19/16 Brandon           Created script
 * 11/19.1/16 Jacob           Did everything in the script
/*
/****************************************************************************************/

public class Gauge : MonoBehaviour {

	public GameObject node1;
	public GameObject node2;
	public GameObject node3;
	public Image nodeImage1;
	public Image nodeImage2;
	public Image nodeImage3;
	public Sprite redNode;
	public Sprite blueNode;
	public Sprite yellowNode;
	public Stack held_power_ups;
	private char getpwr;

	// Use this for initialization
	void Start () {
		node1 = GameObject.Find ("Canvas/gaugeHousing/gaugeNode 1");
		node2 = GameObject.Find ("Canvas/gaugeHousing/gaugeNode 2");
		node3 = GameObject.Find ("Canvas/gaugeHousing/gaugeNode 3");
		nodeImage1 = node1.GetComponent<Image> ();
		nodeImage2 = node2.GetComponent<Image> ();
		nodeImage3 = node3.GetComponent<Image> ();
		Color c = nodeImage1.color;
		c.a = 0;
		nodeImage1.color = c;
		nodeImage2.color = c;
		nodeImage3.color = c;
		held_power_ups = GameObject.Find ("Player_ship").GetComponent<Player_control> ().held_power_ups;
	}

	// Update is called once per frame
	void Update () {
		Color c = nodeImage1.color;
		c.a = 1f;
		if (held_power_ups.Count == 1) {
			getpwr = (char)held_power_ups.Peek ();
			if (getpwr == 'r') {
				nodeImage1.sprite = redNode;
			} else if (getpwr == 'b') {
				nodeImage1.sprite = blueNode;
			} else if (getpwr == 'y') {
				nodeImage1.sprite = yellowNode;
			}
			nodeImage1.color = c;
		} else if (held_power_ups.Count == 2) {
			getpwr = (char)held_power_ups.Peek ();
			if (getpwr == 'r') {
				nodeImage2.sprite = redNode;
			} else if (getpwr == 'b') {
				nodeImage2.sprite = blueNode;
			} else if (getpwr == 'y') {
				nodeImage2.sprite = yellowNode;
			}
			nodeImage2.color = c;
		} else if (held_power_ups.Count == 3) {
			getpwr = (char)held_power_ups.Peek ();
			if (getpwr == 'r') {
				nodeImage3.sprite = redNode;
			} else if (getpwr == 'b') {
				nodeImage3.sprite = blueNode;
			} else if (getpwr == 'y') {
				nodeImage3.sprite = yellowNode;
			}
			nodeImage3.color = c;
		} else {
			c.a = 0;
			nodeImage1.color = c;
			nodeImage2.color = c;
			nodeImage3.color = c;
			c.a = 1f;
		}
	}
}
