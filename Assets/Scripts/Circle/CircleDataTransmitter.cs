using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleDataTransmitter : MonoBehaviour
{
    [SerializeField] private CircleInputController _circleInputController;

    public bool GetIsTouching()
    {
        return _circleInputController.isTouching;
    }
}
