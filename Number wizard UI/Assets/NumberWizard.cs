using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour {
	int max = 1000;
	int min = 1;
	int guess = 500;
	public int maxGuessAllowed = 10;

	public Text text;

	void Start ()
	{
		StartGame();
	}
	void StartGame()
	{
		max = 1000;
		min = 1;
		guess = 500;
		maxGuessAllowed = 10;
	}

	public void GuessHigher()
	{
		min = guess;
		NextGuess();
	}

	public void GuessLower()
	{
		max = guess;
		NextGuess();
	}

	void NextGuess()
	{
		guess = (max + min) / 2;
		text.text = guess.ToString();
		maxGuessAllowed = maxGuessAllowed - 1;
		if(maxGuessAllowed <= 0)
		{
			Application.LoadLevel("WIN");
		}
	}
}
