using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    Ball ballScript;

    public Text CounterText;

    private int Count = 0;

    void Start()
    {
        ballScript = FindObjectOfType<Ball>();
        Count = 0;
    }

    void OnTriggerEnter(Collider other)
    {
        Count += 1;
        CounterText.text = "Count : " + Count;
        Destroy(other);
        ballScript.BallInstantiater();
    }
}
