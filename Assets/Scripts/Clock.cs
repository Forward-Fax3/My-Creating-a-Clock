using System;
using UnityEngine;

public class Clock : MonoBehaviour
{
	[SerializeField] private
	Transform hoursPivot, minutePivot, secondPivot;

	const float hoursToDegrees = 30.0f, minutesToDegrees = 6.0f, secondsToDegrees = 6.0f;

    void Awake()
	{
		DateTime timeNow = DateTime.Now;
		
		float millisecondsAngle = (float)timeNow.Millisecond / 1000.0f;
		float secondsAngle = secondsToDegrees * ((float)timeNow.Second + millisecondsAngle);
		float minutesAngle = minutesToDegrees * ((float)timeNow.Minute + (secondsAngle / 360.0f));
		float hoursAngle = hoursToDegrees * ((float)timeNow.Hour + (minutesAngle / 360.0f));

		hoursPivot.localRotation = Quaternion.Euler(0, 0, -hoursAngle);
		minutePivot.localRotation = Quaternion.Euler(0, 0, -minutesAngle);
		secondPivot.localRotation = Quaternion.Euler(0, 0, -secondsAngle);
	}

	void Update()
	{
        DateTime timeNow = DateTime.Now;

		float millisecondsAngle = (float)timeNow.Millisecond / 1000.0f;
      float secondsAngle = secondsToDegrees * ((float)timeNow.Second + millisecondsAngle);
        float minutesAngle = minutesToDegrees * ((float)timeNow.Minute + (secondsAngle / 360.0f));
        float hoursAngle = hoursToDegrees * ((float)timeNow.Hour + (minutesAngle / 360.0f));

        hoursPivot.localRotation = Quaternion.Euler(0, 0, -hoursAngle);
        minutePivot.localRotation = Quaternion.Euler(0, 0, -minutesAngle);
        secondPivot.localRotation = Quaternion.Euler(0, 0, -secondsAngle);
    }
}