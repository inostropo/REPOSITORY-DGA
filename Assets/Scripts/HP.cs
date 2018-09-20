using System.Collections;
using System.Collections.Generic;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine;
using UnityEngine.UI;
using TMPro;



public class HP : MonoBehaviour {

    //Script by Claudio Inostroza

    public TextMeshProUGUI HPText; //Text for Hp hud
    public float StartingHealth = 3f;  //The starting hp when level is loaded
    public float CurrentHealth = 3f;   //The current hp
    public Slider Hpslider;
    float UICurrentHealth;
    public float AnimationTime = 5f;
    public Animator Player;
    public GameObject PlayerObj;
    public AudioSource DamageSFX;
    public AudioSource DeadSFX;
    public GameObject Gameover;
    public bool isdead = false;
    

    bool Damaged;

	// Use this for initialization
	void Start ()
    {
        // Find the player
        PlayerObj = GameObject.FindGameObjectWithTag("Player");
        Player = PlayerObj.GetComponent<Animator>();

        //set the Hud
        CurrentHealth = StartingHealth;
        UICurrentHealth = CurrentHealth;
        HPText.text = UICurrentHealth.ToString("0") + " / " + StartingHealth;
        Hpslider.maxValue = StartingHealth;
    }
	
	// Update is called once per frame
	void Update ()
    {
        CurrentHealth = Mathf.Clamp(CurrentHealth, 0, StartingHealth);
        Hpslider.maxValue = StartingHealth;
        Hpslider.value = UICurrentHealth;
        HPText.text = UICurrentHealth.ToString("0") + " / " + StartingHealth;
        if (Damaged)
        {
            DamageSFX.Play();
            Damaged = false;
            Player.SetTrigger("Damage");
        }
        if (isdead)
        {
            Player.SetTrigger("Dead");
        }

        // Fade de healt numbers

        if (UICurrentHealth != CurrentHealth && CurrentHealth > 0f)
        {
            if (UICurrentHealth < CurrentHealth)
            {
                UICurrentHealth += (AnimationTime * Time.deltaTime) * (CurrentHealth - UICurrentHealth);

                if (UICurrentHealth >= CurrentHealth)
                    UICurrentHealth = CurrentHealth;
            }
            else
            {
                UICurrentHealth -= (AnimationTime * Time.deltaTime) * (UICurrentHealth - CurrentHealth);

                if (UICurrentHealth <= CurrentHealth)
                    UICurrentHealth = CurrentHealth;
            }

        }
        else if (CurrentHealth == 0)
        {
            UICurrentHealth -= (AnimationTime * Time.deltaTime) * (UICurrentHealth - CurrentHealth);
        }
        else if (UICurrentHealth < 0f)
        {
            UICurrentHealth = 0;
        }

      
      
    }

    // Update damege received
    void TakeDamage(float Damage)
    {
        CurrentHealth -= Damage;
        

        if (CurrentHealth <= 0)
        {
           
            CurrentHealth = 0;
            isdead = true;
            Dead();
        }
        else
        {
            Damaged = true;
        }
    }
    void Restore(float RestoredHp)
    {
        CurrentHealth += RestoredHp;

    }
    //It is loaded when Hp reaches 0
    void Dead()
    {
        if(CurrentHealth >= 0 && isdead)
        {
            DeadSFX.Play();
            Player.SetTrigger("Dead");
            Gameover.SendMessage("IsDead");
        }
        
    }
}
