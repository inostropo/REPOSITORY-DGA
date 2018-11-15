using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour {

   
    public TextMeshProUGUI ScoreText;
    public TextMeshProUGUI ScoreTextGameOver;
    public TextMeshProUGUI HiScoreText;
    public TextMeshProUGUI CoinsText;
    public TextMeshProUGUI CoinsTextGameOver;
    public TextMeshProUGUI Message;

    public Color Patetic;
    public Color Good;
    public Color Impresive;
    public Color Awasome;
    public Color Legendary;

    public float ScoreFloat;
    public float HiScoreFloat;
    public float CoinsFloat;
    // Use this for initialization
    void Start () {
        ScoreText.text = ScoreFloat.ToString("000");
        CoinsFloat = 0f;
    }
	
	// Update is called once per frame
	void Update () {
        ScoreText.text = ScoreFloat.ToString("000");
        
        CoinsText.text = CoinsFloat.ToString("000");
        ScoreTextGameOver.text = ScoreFloat.ToString("000");
        CoinsTextGameOver.text = CoinsFloat.ToString("000");

        if (ScoreFloat <= 10f)
        {
            Message.text = "Patetic";
            Message.color = Patetic;
        }
        if (ScoreFloat > 10f && ScoreFloat <= 100f)
        {
            Message.text = "Good";
            Message.color = Good;
        }
        if (ScoreFloat > 100f && ScoreFloat <= 250f)
        {
            Message.text = "Impresive";
            Message.color = Impresive;
        }
        if (ScoreFloat > 250f && ScoreFloat <= 750f)
        {
            Message.text = "Awasome!";
            Message.color = Awasome;
        }
        if (ScoreFloat >= 750f)
        {
            Message.text = "Legendary!!!";
            Message.color = Legendary;
        }
    }
    void CoinCout(float Count)
    {
        CoinsFloat += Count;
    }
    void ScoreCount(float Score)
    {
        ScoreFloat += Score;
    }
}
