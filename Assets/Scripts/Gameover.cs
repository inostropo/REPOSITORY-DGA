using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script by Claudio Inostroza

public class Gameover : MonoBehaviour {

    public CanvasGroup UiGameover;
    public CanvasGroup HudIngame;
    public AudioSource GameOverSfx;
    public bool ItGameover;
 

	// Use this for initialization
	void Start ()
    {
        ItGameover = false;
    }
	
	// Update is called once per frame
	void Update ()
    {
		if (ItGameover)
        {
            HudIngame.interactable = false;
            UiGameover.interactable = true;
            HudIngame.alpha -= 0.1f;
            UiGameover.alpha += 0.1f;
        }
        else
        {
            HudIngame.interactable = true;
            HudIngame.alpha += 0.1f;
            UiGameover.interactable = true;
            UiGameover.alpha -= 0.1f;
        }

        Mathf.Clamp(UiGameover.alpha, 0f, 1f);
        Mathf.Clamp(HudIngame.alpha, 0f, 1f);

    }
    public void IsDead()
    {
        GameOverSfx.Play();
        ItGameover = true;
    }

}
