using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockController : MonoBehaviour
{
    public Transform hourHand;
    public Transform minuteHand;
    public Transform secondHand;

    void Update()
    {
        DateTime now = DateTime.Now;
        float hours = now.Hour;
        float minutes = now.Minute;
        float seconds = now.Second;

        UpdateClockHands(hours, minutes, seconds);
    }

    void UpdateClockHands(float hours, float minutes, float seconds)
    {
        // Calculate rotation angles for hour, minute, and second hands
        float hourAngle = 360f * ((hours % 12f) / 12f); // Ensure hours are in 12-hour format
        float minuteAngle = 360f * (minutes / 60f);
        float secondAngle = 360f * (seconds / 60f);

        // Apply rotation to clock hands
        hourHand.localRotation = Quaternion.Euler(0f, 0f, -hourAngle);
        minuteHand.localRotation = Quaternion.Euler(0f, 0f, -minuteAngle);
        secondHand.localRotation = Quaternion.Euler(0f, 0f, -secondAngle);
    }
}
