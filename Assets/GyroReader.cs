using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GyroReader : MonoBehaviour
{
    public Text Attitude;
    public Text Gravity;
    public Text RotationRate;
    public Text RotationRateUnbiased;
    public Text UpdateInterval;
    public Text UserAccel;

    void Awake() => Input.gyro.enabled = true;

    void Update()
    {
        var gyro = Input.gyro;

        Attitude.text = gyro.attitude.ToString();
        Gravity.text = gyro.gravity.ToString();
        RotationRate.text = gyro.rotationRate.ToString();
        RotationRateUnbiased.text = gyro.rotationRateUnbiased.ToString();
        UpdateInterval.text = gyro.updateInterval.ToString();
        UserAccel.text = gyro.userAcceleration.ToString();
    }
}
