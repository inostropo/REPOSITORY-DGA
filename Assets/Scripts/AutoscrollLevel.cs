using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoscrollLevel : MonoBehaviour {

    public GameObject LevelToScroll;
    public Vector3 AxisToscroll;
    public bool Move;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Move)
        {
            LevelToScroll.transform.Translate(AxisToscroll * Time.deltaTime);
        }
       
      
	}
}
