using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour {

    public GameObject player;
    public GameObject GameController;
    public GameObject RestorerPick;
    BoxCollider2D PickUpcollider;
    public float Timedestroy = 1f;
    public AudioSource Sfx;

    public float Count = 1f;
    public string Player = "Player";
    public ParticleSystem PkUpfx;


    // Use this for initialization
    void Start()
    {
        GameController = GameObject.FindGameObjectWithTag("GameController");
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
            GameController.SendMessage("CoinCout", Count);
           
            Destroy(this.gameObject, Timedestroy);
        }

    }
   
	
}
