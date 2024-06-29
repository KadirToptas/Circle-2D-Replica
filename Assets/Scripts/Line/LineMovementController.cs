using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineMovementController : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    
    void Update()
    {
        SetLineMovement();
    }

    private void SetLineMovement()
    {
        transform.Translate(Vector2.left * moveSpeed*Time.deltaTime);
    }
}
