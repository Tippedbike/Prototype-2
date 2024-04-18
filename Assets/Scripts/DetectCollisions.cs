using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    private GameManager gameManager;
    public int pointValue;
    // Start is called before the first frame update
    void Start()
    {
    }
    void OnTriggerEnter(Collider other)
    {
        if (gameObject)
        {
        Destroy(gameObject);
        Destroy(other.gameObject);
        gameManager.UpdateScore(pointValue);
        }
    }
    // Update is called once per frame
    void Update()
    {
   
    }
}
