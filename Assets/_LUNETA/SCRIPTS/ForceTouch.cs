using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.iOS;

public class ForceTouch : MonoBehaviour
{
    public float pressure;

    void Update()
    {
        if (Input.touchPressureSupported)
        {
            pressure = Input.GetTouch(0).pressure;
        }
    }

}
