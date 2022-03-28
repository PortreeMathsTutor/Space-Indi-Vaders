using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScorUpdator : MonoBehaviour
{
    public int score;
    public int highScoreInt = 0;
    public TextMeshProUGUI scoreTex;
    public TextMeshProUGUI highScoreTex;
    // Start is called before the first frame update
    void Start()
    {
        highScoreTex.text = "HIGHSCORE: " + PlayerPrefs.GetInt("highScore23", 0).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        score = PlayerBullet.score;


        if (score < 0) { score = 0; }
        scoreTex.text = "SCORE: " + score.ToString("0");

        if (score > PlayerPrefs.GetInt("highScore23", 0))
        {
            PlayerPrefs.SetInt("highScore23", score);
            highScoreTex.text = "HIGHSCORE: " + score.ToString();
        }
    }
}