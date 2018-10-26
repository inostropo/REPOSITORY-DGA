using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Script by Claudio Inostroza

public class Gameover : MonoBehaviour {

    public CanvasGroup UiGameover;
    public CanvasGroup HudIngame;
    public AudioSource GameOverSfx;
    public bool ItGameover;
    public GameObject LavaObj;

 

	// Use this for initialization
	void Start ()
    {
        ItGameover = false;
        UiGameover.interactable = false;
    }
	
	// Update is called once per frame
	void Update ()
    {
		if (ItGameover)
        {
            HudIngame.interactable = false;
           
            HudIngame.alpha -= 0.1f;
            UiGameover.alpha += 0.1f;
            Invoke("ButtonEnable", 4f);
        }
        else
        {
            HudIngame.interactable = true;
            HudIngame.alpha += 0.1f;
            
            UiGameover.alpha -= 0.1f;
        }

        Mathf.Clamp(UiGameover.alpha, 0f, 1f);
        Mathf.Clamp(HudIngame.alpha, 0f, 1f);

    }
    public void IsDead()
    {
        GameOverSfx.Play();
        ItGameover = true;
        LavaObj.SendMessage("StopLava");
    }
    void ButtonEnable()
    {
        UiGameover.interactable = true;
    }
}
