using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    protected ScoreManager scoreManager;
    protected void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerCollision();
        }
    }
    protected virtual void PlayerCollision()
    {
        scoreManager.AddScore(5);
        Destroy(this.gameObject);
    }
    private void Update()
    {
        if(transform.position.y < -2)
        {
            Destroy(this.gameObject);
        }
    }
}
