using UnityEngine;
using System.Collections;

public class ScrollingUvs : MonoBehaviour
{
    // Scroll main texture based on time

    public bool X;
    public bool Y;
    public float scrollSpeed = 0.5f;
    Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    void Update()
    {
        float offset = Time.time * scrollSpeed;

        if (X && !Y)
        {
            rend.material.SetTextureOffset("_MainTex", new Vector2(offset, 0));
        }
        if (Y && !X)
        {
            rend.material.SetTextureOffset("_MainTex", new Vector2(0, offset));
        }
        if (Y && X)
        {
            rend.material.SetTextureOffset("_MainTex", new Vector2(offset, offset));
        }
    
    }
}