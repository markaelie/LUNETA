using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ApplicationVersion : MonoBehaviour
{
	string version;
	Text txt;

    void Start()
    {
    	version = Application.version;
    	txt = GetComponent<Text>();
    	txt.text = "" + version;
    }
}