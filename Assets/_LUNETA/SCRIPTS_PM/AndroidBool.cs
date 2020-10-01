// (c) Copyright HutongGames, LLC 2010-2013. All rights reserved.

using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Device)]
	[Tooltip("Set a Bool value if device is Android")]
	public class AndroidBool : FsmStateAction
	{
		[UIHint(UIHint.Variable)]
		[Tooltip("Android = True , Other = false")]
		public FsmBool deviceIsAndroid;
		
		public override void OnEnter()
		{
    if (Application.platform == RuntimePlatform.Android)
	{
deviceIsAndroid.Value = true;
	Finish();
    }
    else
    {
      deviceIsAndroid.Value = false;
	Finish();
	}	
    
	}
	}
}