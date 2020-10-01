using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using HutongGames.PlayMaker;

public class FPSDisplay : MonoBehaviour
{
    float deltaTime = 0.0f;
    bool fpsDisplay;

    private void Start()
    {
        //fpsDisplay = FsmVariables.GlobalVariables.GetFsmBool("FPSDISPLAY").Value;
    }

    void Update()
    {
        fpsDisplay = FsmVariables.GlobalVariables.GetFsmBool("FPSDISPLAY").Value;
        deltaTime += (Time.deltaTime - deltaTime) * 0.1f;
    }

    void OnGUI()
    {
        if (fpsDisplay)
        {
            int w = Screen.width, h = Screen.height;
            GUIStyle style = new GUIStyle();
            Rect rect = new Rect(0, 0, w, h * 2 / 100);
            style.alignment = TextAnchor.UpperLeft;
            style.fontSize = h * 2 / 100;
            style.normal.textColor = new Color(250f, 250f, 250f, 250f);
            float msec = deltaTime * 1000.0f;
            float fps = 1.0f / deltaTime;
            string text = string.Format("{0:0.0} ms ({1:0.} fps)", msec, fps);
            GUI.Label(rect, text, style);
        }
    }
}
