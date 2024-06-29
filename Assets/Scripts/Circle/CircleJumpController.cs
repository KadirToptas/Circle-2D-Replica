using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleJumpController : MonoBehaviour
{
    [SerializeField] private CircleDataTransmitter _circleDataTransmitter;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float circleJumpForce;
    
    void FixedUpdate()
    {
        SetCircleJumpForce();
    }

    private void SetCircleJumpForce()
    {
        if (_circleDataTransmitter.GetIsTouching())
        {
            rb.velocity = Vector2.up*circleJumpForce*Time.fixedDeltaTime;

        }
    }
}
