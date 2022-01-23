using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class Manager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private TextMeshProUGUI highscore;
    void Start()
    {
        LoadHighScore();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
    void LoadHighScore()
    {
        highscore.text = "Highscore: " + PlayerPrefs.GetInt("HighScore", 0);
    }
}
