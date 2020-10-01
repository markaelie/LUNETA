using UnityEngine;
using System.Collections;

public class FramesPerSecond : MonoBehaviour
{
    public int framesPerSecond = 75;

    void Awake()
    {
        Application.targetFrameRate = framesPerSecond;
    }
}
