using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleDataTransmitter : MonoBehaviour
{
    [SerializeField] private CircleInputController _circleInputController;
    [SerializeField] private CircleScoreController _circleScoreController;

    public bool GetIsTouching()
    {
        return _circleInputController.isTouching;
    }
    
    public void IncreaseScoreValue(){
        _circleScoreController.IncreaseScore();
    }
}
