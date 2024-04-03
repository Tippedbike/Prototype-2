using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    private int score; 
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        UpdateScore(0);
    }
    void OnTriggerEnter(Collider other)
    {
        if (gameObject )
        {
        Destroy(gameObject);
        Destroy(other.gameObject);
        }
    }
    // Update is called once per frame
   public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        Debug.Log("Score: " + score);
    }
}
