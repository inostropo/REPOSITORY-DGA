using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerCorrector : MonoBehaviour {

    public GameObject Spawner;
    public string ColliderTag="Platform";
    public Vector3 InicialPosicion;

    private void Start()
    {
        InicialPosicion = Spawner.transform.position;
    }
    void FixedUpdate()
    {
        if (Spawner.transform.position != InicialPosicion)
        {
            RestartPosition();
        }

    }
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag(ColliderTag))
        {
            CancelInvoke();
            Spawner.transform.Translate(0f, 10f, 0f);
            Invoke("RestartPosition", 2f);
        }
    }
    void RestartPosition()
    {
        Spawner.transform.position = InicialPosicion;
    }
}
