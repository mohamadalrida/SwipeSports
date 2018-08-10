using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenVOIDFALL : MonoBehaviour {

    public bool Android;
    public bool iOS;

	public void OpenVF()
    {
        if (Android == true)
        {
            Application.OpenURL("https://play.google.com/store/apps/details?id=com.BigThinkStudios.VoidFall1");
        }
        else if (iOS == true)
        {
            Application.OpenURL("https://itunes.apple.com/au/app/void-fall/id1417630235?mt=8");
        }
    }

    
}
