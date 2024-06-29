using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraColorController : MonoBehaviour
{
    [SerializeField] private Camera mainCamera;
    [SerializeField] private Color[] colors;
    private int colorIndex;
    [SerializeField] private float lerpValue;

    [SerializeField] private float _time;
    private float currentTime;
    void Start()
    {
        mainCamera = Camera.main;
    }

    void Update()
    {
        ChangeSmoothCameraColors();
        SetColorChangeTime();
    }

    private void ChangeSmoothCameraColors()
    {
        mainCamera.backgroundColor = Color.Lerp(mainCamera.backgroundColor,colors[colorIndex], lerpValue*Time.deltaTime);
    }

    private void SetColorChangeTime()
    {
        if (currentTime <= 0)
        {
            IncreaseColorIndexValues();
            CheckColorIndexValues();
            currentTime = _time;
        }
        else
        {
            currentTime -= Time.deltaTime;
        }
    }

    private void IncreaseColorIndexValues()
    {
        colorIndex++;
    }


    private void CheckColorIndexValues()
    {
        if (colorIndex >= colors.Length)
        {
            colorIndex = 0;
        }
    }

    private void OnDestroy()
    {
        mainCamera.backgroundColor = colors[1];
    }
}
