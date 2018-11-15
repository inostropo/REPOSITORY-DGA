using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnPlatform : MonoBehaviour {

    public float TimeToRespawn = 2f;
    public GameObject PlatformToRespawn;
    public GameObject Replacer;
    public ParticleSystem FxRespawn;
    bool respawn;



    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Lava"))
        {
            Destroy(this.gameObject);
        }

    }

    // Update is called once per frame
    void LateUpdate ()
    {

        if (PlatformToRespawn == null && !respawn)
        {
            respawn = true;
            Invoke("ReplacerPlatformer", TimeToRespawn);
        }
    
	}
    void ReplacerPlatformer()
    {
        FxRespawn = Instantiate(FxRespawn, transform);
      
        PlatformToRespawn = Instantiate(Replacer, transform);
        respawn = false;
    }
  
}
