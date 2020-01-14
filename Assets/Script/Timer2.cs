using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Timer2 : MonoBehaviour {


    private CountdownTimer countdownTimer;
    private Slider sliderUI;
    private int startSeconds = 15;
    public Text value;
    float val;
    public string sceneName;

    void Start()
    {
        SetupSlider();
        SetupTimer();
    }

    void Update()
    {
        sliderUI.value =
        countdownTimer.GetProportionTimeRemaining();
        print(countdownTimer.GetProportionTimeRemaining());
        val = countdownTimer.GetProportionTimeRemaining();
        value.text = Convert.ToString(val);
        if (countdownTimer.GetProportionTimeRemaining() == 0)
        {
            GotoPage();
        }
    }

    private void SetupSlider()
    {
        sliderUI = GetComponent<Slider>();
        sliderUI.minValue = 0;
        sliderUI.maxValue = 1;
        sliderUI.wholeNumbers = false;
    }

    private void SetupTimer()
    {
        countdownTimer = GetComponent<CountdownTimer>();
        countdownTimer.ResetTimer(Convert.ToInt16(startSeconds));
    }

    private void GotoPage()
    {
        Application.LoadLevel(sceneName);
    }
}

