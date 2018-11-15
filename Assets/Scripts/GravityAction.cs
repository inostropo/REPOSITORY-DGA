using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityAction : MonoBehaviour
{

    //script hecho por claudio Inostroza
    [Tooltip("Start gravity to platform")]
    public float StartPlatformGravity = 10f;
    [Tooltip("Player tag identifier")]
    public string Player = "Player";
    [Tooltip("platform whit rigidbody2d to apply gravity")]
    public Rigidbody2D Platform;
    [Tooltip("Player is in range?")]
    public bool PlayerInRange;

    [Tooltip("How many gravity is applied to platform in contact whit the player ")]
    public float GravityInRange = 1f;
    [Tooltip("Time to active the gravity when the player enter in contact (0 is immediately)")]
    public float TimeToFall = 0.5f;

    // Use this for initialization
    void Start()
    {
        Platform.gravityScale = StartPlatformGravity;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag(Player))
        {
            PlayerInRange = true;
            Invoke("FallDelay", TimeToFall);
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag(Player))
        {
            PlayerInRange = false;
            CancelInvoke("FallDelay");
        }
    }
    void FallDelay()
    {
       
        Platform.isKinematic = false;
        Platform.gravityScale = StartPlatformGravity;
    }
}
