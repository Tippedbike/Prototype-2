using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    private int score; 
    private int lives;
    void Start()
    {
        score = 0;
        UpdateScore(0);
    }

    // Update is called once per frame
    public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        Debug.Log("Score: " + score);
    }
}