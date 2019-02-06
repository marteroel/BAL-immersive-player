﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VideoDisplaySelector : MonoBehaviour
{
	#region Public variables
	public GameObject semisphere;
	public GameObject fullsphere;

	[HideInInspector]
	public GameObject selectedDisplay;
	#endregion

	#region Unity Methods
    void Awake()
    {
		if (VideoPlayerSettings.is360) {
			semisphere.SetActive (false);
			fullsphere.SetActive (true);
			selectedDisplay = fullsphere;
		} 

		else {
			semisphere.SetActive (true);
			fullsphere.SetActive (false);
			selectedDisplay = semisphere;
		}

        
    }
		
	#endregion
}
