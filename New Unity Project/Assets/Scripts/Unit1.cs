using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Unit1 : Unit
{
    // Start is called before the first frame update
    // INHERITANCE
    protected override void PlayerCollision()// POLYMORPHISM
    {
        if (scoreManager.score > PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", scoreManager.score);
           

        }
        SceneManager.LoadScene(0);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

}
