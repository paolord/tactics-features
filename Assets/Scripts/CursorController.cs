using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class CursorController : MonoBehaviour
{
    [SerializeField] private float transparencyHigh = 0.8f;
    [SerializeField] private float transparencyLow = 0.5f;
    [SerializeField] private float animationSpeed = 0.5f;

    private SpriteRenderer _renderer;
    private bool _light;
    void Awake()
    {
        _renderer = GetComponent<SpriteRenderer>();
        // var spriteColor = GetComponent<SpriteRenderer>().color;
        //
        // spriteColor.a = transparency;
        //
        // GetComponent<SpriteRenderer>().color = spriteColor;
    }

    private void Start()
    {
        _light = true;
        InvokeRepeating(nameof(DoAnimation), 0, animationSpeed);
    }

    // Update is called once per frame
    // void FixedUpdate()
    // {
    //     Debug.Log(Time.deltaTime);
    //     if (_previousFrame > animationSpeed)
    //     {
    //         var color = _renderer.color;
    //         color.a = 1f;
    //         
    //     }
    //     
    //     _previousFrame = Time.deltaTime;
    // }

    void DoAnimation()
    {
        var color = _renderer.color;
        color.a = _light ? transparencyHigh : transparencyLow;
        _renderer.color = color;
        _light = !_light; // invert lightness of transparency
    }
}
