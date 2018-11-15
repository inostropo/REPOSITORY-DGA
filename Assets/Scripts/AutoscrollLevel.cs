using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoscrollLevel : MonoBehaviour {

    public GameObject LevelToScroll;
    public Vector3 AxisToScroll;
    public bool Move;
    
	// Use this for initialization
	void Start () {
        Move = true;
    }
	
	// Update is called once per frame
	void Update () {

        if (Move)
        {
            LevelToScroll.transform.Translate(AxisToScroll * Time.deltaTime);
        }
       
      
	}
    public void StopLava()
    {
        Move = false;
    }
    public void StartLava()
    {
        Move = false;
    }
}
