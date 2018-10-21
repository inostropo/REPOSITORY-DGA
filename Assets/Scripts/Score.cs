using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour {

    public GameObject LevelScore;
    public TextMeshProUGUI ScoreText;
    public TextMeshProUGUI HiScoreText;
    public TextMeshProUGUI CoinsText;
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
        ScoreFloat = LevelScore.transform.localPosition.y;
        CoinsText.text = CoinsFloat.ToString("000");
    }
    void CoinCout(float Count)
    {
        CoinsFloat += Count;
    }
}
