using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPlatformGenerator : MonoBehaviour {

    
    public Transform SpawnerLocation;
    public bool GeneratePlatformsSwitch;
    public float FrequencyOfGeneration;
    public float IntervalFrequencyOfGeneration;
    public GameObject[] Platforms;
    int RandomInt;
    // Use this for initialization
    void Start ()
    {
        SpawnerLocation.GetComponent<Transform>();
        GeneratePlatformsSwitch = false;
        FrequencyOfGeneration = 0f;
        GeneratePlatforms();
    }
	
	// Update is called once per frame
	void Update ()
    {
        FrequencyOfGeneration = Mathf.Clamp(FrequencyOfGeneration, 0f, IntervalFrequencyOfGeneration);
        FrequencyOfGeneration += Time.deltaTime;

        if (FrequencyOfGeneration >= IntervalFrequencyOfGeneration)
        {
            GeneratePlatformsSwitch = true;
        }

		if (GeneratePlatformsSwitch && Time.deltaTime !=0f)//enable and disable the generation
        {
            GeneratePlatforms();
        }
	}
    void GeneratePlatforms()
    {
        RandomInt = Random.Range(0, Platforms.Length);
        Instantiate ( Platforms [RandomInt], SpawnerLocation. position, SpawnerLocation.rotation);
        GeneratePlatformsSwitch = false;
        FrequencyOfGeneration = 0f;
    }
}
