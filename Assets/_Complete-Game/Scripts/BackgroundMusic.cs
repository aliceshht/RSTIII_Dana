using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusic : MonoBehaviour {

	public AudioSource birdsFlying;

	public AudioSource WindBlowing;
	void Awake(){DontDestroyOnLoad(this);}

	float seconds;
	void Update()
	{
		seconds+= Time.deltaTime;
		if(Mathf.Round(seconds) == 15)
		{
			birdsFlying.Play();
		}
	}
}
