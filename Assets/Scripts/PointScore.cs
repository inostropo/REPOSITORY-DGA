using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointScore : MonoBehaviour {

    public GameObject Meterpoint;
    public GameObject PlayerControler;
    public float Meters = 1f;
    public string Player = "Player";
    public string Lava = "Lava";

    private void Start()
    {
        Meterpoint = this.gameObject;
        PlayerControler = GameObject.FindGameObjectWithTag("GameController");
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag(Player))
        {
            PlayerControler.SendMessage("MeterCount", Meters);
            Destroy(Meterpoint);
        }
        else if (other.gameObject.CompareTag(Lava))
        {
            Destroy(Meterpoint);
        }
    }
}
