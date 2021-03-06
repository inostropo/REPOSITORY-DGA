﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Script by Claudio Inostroza

[RequireComponent(typeof(BoxCollider2D))]
public class Restorer : MonoBehaviour {

    public GameObject player;
    public GameObject RestorerPick;
    BoxCollider2D PickUpcollider;
    public float Timedestroy = 1f;
    public AudioSource Sfx;
    public float RestoredHp = 2f;
    public string Player = "Player";
    public ParticleSystem PkUpfx;
   

	// Use this for initialization
	void Start () {

        player = GameObject.FindGameObjectWithTag("Player");
        PickUpcollider = RestorerPick.GetComponent<BoxCollider2D>();
        
    }
	
	// Update is called once per frame
	void OnTriggerEnter2D(Collider2D other)
    {
		
        if (other.gameObject.CompareTag(Player))
        {
            Sfx.Play();
            PkUpfx.Play();
            PickUpcollider.enabled = false;
            RestorerPick.GetComponent<SpriteRenderer>().enabled = false;
            other.gameObject.SendMessage("Restore", RestoredHp);
           
            Destroy(this.gameObject, Timedestroy);
        }

	}

}
