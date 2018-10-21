using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityAction : MonoBehaviour {

    //script hecho por claudio Inostroza
    [Tooltip("Player tag identifier")]
    public string Player = "Player";
    [Tooltip("platform whit rigidbody2d to apply gravity")]
    public Rigidbody2D Platform;
    [Tooltip("Player is in range?")]
    public bool PlayerInRange;
    [Tooltip("If dinamic ,the platform stop the simulation of gravity if the player is´nt in range")]
    public bool DinamicPlatform;
	// Use this for initialization
	void Start () {
		
	}

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag(Player))
        {
            PlayerInRange = true;
            Platform.gravityScale = 1;
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag(Player))
        {
            PlayerInRange = false;
            if (DinamicPlatform)
            {
                Platform.gravityScale = 0;
            }
           
        }
    }
}
