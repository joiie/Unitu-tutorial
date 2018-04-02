using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {
	int max = 1000;
	int min = 1;
	int guess = 500;
	void Start ()
	{
		StartGame();
	}
	void StartGame()
	{
		max = 1000;
		min = 1;
		guess = 500;

		print( "Welcome to NumberWizard!");
		print( "Pick a number, any number");
		print("The height number you can pick is: " + max);
		print("The lowest number you can pick is: " + min);
		print( "Is the number higher or lower than 500?");
		print( "Arrow up for higher, down for lower, return for equal");

	}
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.UpArrow))
		{
			min = guess;
			NextGuess();
		}
		else if(Input.GetKeyDown(KeyCode.DownArrow))
		{
			print("You pressed DOWN!");
			max = guess;
			NextGuess();
		}
		else if(Input.GetKeyDown(KeyCode.Return))
		{
			print("I won!");
			StartGame();
		}
	}

	void NextGuess()
	{
		guess = (max + min) / 2;
		print ("Higher or lower than " + guess +"?");
		print( "Arrow up for higher, down for lower, return for equal");
	}
}
