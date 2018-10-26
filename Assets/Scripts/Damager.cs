using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script by Claudio Inostroza

[RequireComponent(typeof(BoxCollider2D))]
public class Damager : MonoBehaviour {

    public GameObject player;
    public GameObject spawner;
    public float Damage = 2f;
    public string Player = "Player";
    public bool PlayerInRange;
    public bool PlayerIsDead;
	// Use this for initialization
	void Start () {

        player = GameObject.FindGameObjectWithTag("Player");
        spawner = GameObject.FindGameObjectWithTag("Spawn");
    }
	
	
	void OnTriggerEnter2D(Collider2D other)
    {
		
        if (other.gameObject.CompareTag(Player)&&!PlayerIsDead)
        {
            PlayerInRange = true;
            other.gameObject.SendMessage("TakeDamage", Damage);
            other.gameObject.transform.position = spawner.transform.position;
        }

	}
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag(Player))
        {
            PlayerInRange = true;
            
        }
    }
    public void PlayerDead()
    {
        PlayerIsDead = true;
    }
}
