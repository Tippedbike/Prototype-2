﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float forwardInput;
    public float speed = 10.0f;
    public float xRange = 10; 
    public float zRange = 10;
    public GameObject projectilePrefab; 

    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update() 
    {
        //keeps player from going out of bounds
if (transform.position.x < -xRange)
{
transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
}
if (transform.position.x > xRange)
{
transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
}

if (transform.position.z < -zRange)
{
transform.position = new Vector3(transform.position.x, transform.position.y, -zRange);
}
if (transform.position.z > zRange)
{
transform.position = new Vector3(transform.position.x, transform.position.y, zRange);
}



        if ( Input.GetKeyDown(KeyCode.Space))
        {
            //launchs projetile from player
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }



        horizontalInput = Input.GetAxis("Horizontal");
        transform. Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);


        forwardInput = Input.GetAxis("Vertical");
        transform. Translate(Vector3.forward * forwardInput * Time.deltaTime * speed);
    }
    //private void OnCollisionEnter(Collision other)
   // {
        // if player collides with bomb, explode and set gameOver to true
        //if (other.gameObject.CompareTag("Rage"))
        //{
            //Debug.Log("Game Over!");
            //Destroy(other.gameObject);
       // } 
    //}
}
