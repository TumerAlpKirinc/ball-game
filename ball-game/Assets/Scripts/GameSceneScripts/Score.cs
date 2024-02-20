using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {
    public Text scoreText;
    private int score = 0;
    public Text highScore;

    
    
    private void Awake() {
        
    }


    // Start is called before the first frame update
    void Start() {
        setHighScore(PlayerPrefs.GetInt("HighScore"));
    }

    // Update is called once per frame
    void Update() {
        
    }

    public void updateScore(int score) {
        this.score += score;
        scoreText.text = this.score.ToString();
    }
    public int getScore() {
        return int.Parse(scoreText.text);
    }
    public int getHighScore() {
        return int.Parse(highScore.text);
    }
    public void setHighScore(int score) {
        highScore.text = score.ToString();
        PlayerPrefs.SetInt("HighScore", score);
    }






}
