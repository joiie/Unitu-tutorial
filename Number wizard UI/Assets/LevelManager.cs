using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

public void LoadLevel(string name)
	{
		Debug.Log("level load requested for: " + name);
		Application.LoadLevel(name);
	}
public void Quit()
	{
		Debug.Log("Program exit requested");
		Application.Quit();
	}
}
