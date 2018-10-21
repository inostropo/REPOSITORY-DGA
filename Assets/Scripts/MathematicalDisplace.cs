using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MathematicalDisplace : MonoBehaviour
{
    [Space(20)]
    [Header("Moviment Options")]
    [Space(20)]


    public GameObject ObjectToMove;
    public float SinNumber =1f;
    public float Velocity =30f;
    public float Distance =2f;

    [Space(20)]
    [Header("Axis")]
    [Space(20)]

    public bool X;
    public bool Y;
    public bool Z;

    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        SinNumber += Time.deltaTime * Velocity;//velocidad
        float SinTemp = Mathf.Sin(SinNumber) * Distance;//distancia
        SinNumber = Mathf.Clamp(SinNumber, -100f, 100f);
        if(SinNumber >=100 || SinNumber <= -100)
        {
            SinNumber = 0f;
        }
        if (Time.deltaTime > 0f)
        {
            if (X)
            {
                ObjectToMove.transform.Translate(new Vector3(SinTemp, 0, 0));
            }

            if (Y)
            {
                ObjectToMove.transform.Translate(new Vector3(0, SinTemp, 0));
            }

            if (Z)
            {
                ObjectToMove.transform.Translate(new Vector3(0, 0, SinTemp));
            }
        }
     


    }
}
