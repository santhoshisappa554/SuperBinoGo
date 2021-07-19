using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float time;
    public float PointdecreasedperSecond;
    public Text timeText;

    private void Start()
    {
        time = 100;
        PointdecreasedperSecond = 1;
    }
    private void Update()
    {
        if (time >= 0)
        {
            time -= PointdecreasedperSecond*Time.deltaTime;
            print("Score is:" + time);

        }

    }
}
