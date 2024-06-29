using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CircleCollisionController : MonoBehaviour
{
    void Start()
    {
        
    }

  
    void Update()
    {
        
    }


    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Line"))
        {
            SceneManager.LoadScene(0);
        }
    }
}
