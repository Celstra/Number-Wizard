using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

    int max;
    int min;
    int guess;
    
    // Use this for initialization
    void Start () {
        StartGame();
    }
	
    void StartGame ()
    {
        max = 1000;
        min = 1;
        guess = 500;
        
        Debug.Log("Welcome to NUMBER WIZARD");
        Debug.Log("We would like you to pick a number that I will then guess!");
        Debug.Log("The HIGHEST number you can choose is: " + max);
        Debug.Log("The LOWEST number you can choose is: " + min);
        Debug.Log("Tell me if your number is higer or lower than: " + guess);
        Debug.Log("Push Up = Higher, Push Down = Lower, Push Enter = Correct");

        max = max + 1;
    }

	// Update is called once per frame
	void Update () {
        //Detect when the up arrow key is pressed down
        if (Input.GetKeyDown(KeyCode.UpArrow))
        { 
            min = guess;
            NextGuess();
        }
        //Detect when the down arrow key is pressed down
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        { 
            max = guess;
            NextGuess();
        }
        //Detect when the Return key is pressed down
        else if(Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("So I am right! Your number is: " + guess);
            StartGame();
        }
    }
    void NextGuess()
    {
        guess = (max + min) / 2;
        Debug.Log("Ok then.. Is it higher or lower than: " + guess);
    }
}
