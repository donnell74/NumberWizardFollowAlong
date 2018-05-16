using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizards : MonoBehaviour {

    private int max;
    private int min;
    private int guess;

    // Use this for initialization
    void Start () {
        StartGame();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            //print("Up arrow pressed");
            min = guess;
            UpdateGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow)) {
            //print("Down arrow pressed");
            max = guess;
            UpdateGuess();
        }
        else if (Input.GetKeyDown(KeyCode.KeypadEnter) || Input.GetKeyDown(KeyCode.Return)) {
            print("I have won!");
            StartGame();
        }
    }

    private void StartGame()
    {
        max = 1000;
        min = 1;

        print("============================================");
        print("Welcome to Number Wizard");
        print("Pick a number in your head, but don't tell me!");

        print("The highest number you can pick is " + max);
        print("The lowest number you can pick is " + min);

        UpdateGuess();

        // Add one to max so we don't get stuck at 999 if the number is 1000.
        max = max + 1;
    }

    private void UpdateGuess()
    {
        guess = (max + min) / 2;
        print("Is the number higher or lower than " + guess + "?");
        print("Up arrow for higher, down arrow for lower, return for equal");
    }
}
