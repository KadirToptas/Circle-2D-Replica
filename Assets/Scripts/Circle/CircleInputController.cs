using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleInputController : MonoBehaviour
{
    [SerializeField] private CircleDataTransmitter _circleDataTransmitter;
    
    public bool isTouching = false;
    void Start()
    {
        
    }

    void Update()
    {
        HandleCircleInput();
    }

    private void HandleCircleInput()
    {
        if (Input.GetMouseButtonDown(0))
        {
            isTouching = true;
            _circleDataTransmitter.IncreaseScoreValue();
        }
        else if (Input.GetMouseButtonUp(0))
        {
            isTouching = false;
        }
    }
}
