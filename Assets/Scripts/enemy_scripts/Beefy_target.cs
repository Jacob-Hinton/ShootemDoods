using UnityEngine;
using System.Collections;

/****************************************************************************************/
/*
/* FILE NAME: Beefy_target
/*
/* DESCRIPTION: this script dictates the behavior of an enemy that can be hit by a player attack
 * several times before being destroyed.
/*
/*
/* DATE     BY     	DESCRIPTION
/* ======== ======= =============
/* 11/25/16	Brandon	created script
/*
/*
/****************************************************************************************/

public class Beefy_target : MonoBehaviour
{
    public int maxhealth_points = 10;
    public int curhealth_points;
    public Transform explosionPrefab;
    public Sprite bloodied;

    void Start()
    {
        curhealth_points = maxhealth_points;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "player_bullet")
        {
            curhealth_points--;
            ContactPoint2D contact = col.contacts[0];
            Quaternion rot = Quaternion.FromToRotation(Vector3.up, contact.normal);
            Vector3 pos = contact.point;
            Instantiate(explosionPrefab, pos, rot);
            if (this.gameObject.tag == "red_enemy")
            {
                this.gameObject.GetComponent<Spawn_powerup>().Spawn();
            }
           // if(curhealth_points < maxhealth_points / 2)
            //{
                
            //}
            if (curhealth_points <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
