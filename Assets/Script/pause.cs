using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pause : MonoBehaviour {
    public bool paused;
    public void PauseGame()
    {
        paused = !paused;
        if (paused)
        {
            Time.timeScale = 0;
            AudioListener.pause = true;
        }else if (!paused)
        {
            Time.timeScale = 1;
            AudioListener.pause = false;
        }
    }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
