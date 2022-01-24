using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    // Start is called before the first frame update
    public int score { get; set; } // ENCAPSULATION
    public TextMeshProUGUI scoretext;
    public  void AddScore(int amount)
    {
        score += amount;
        UpdateScore();
    }
    void UpdateScore() // ABSTRACTION
    {
        scoretext.text = "Score: " + score;
    }
    private void Awake()
    {
        score = 0;
    }
}
