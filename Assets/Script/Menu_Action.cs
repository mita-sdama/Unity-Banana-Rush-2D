using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu_Action : MonoBehaviour {

    public void MENU_ACTION_GotoPage(string sceneName)
    {
        Application.LoadLevel(sceneName);
    }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
