using System;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    private int max;
    private int min;
    private int guess;

    private void Start()
    {
        max = 1000;
        min = 1;
        guess = (max + min) / 2;
        Debug.Log("Welcome to the Number Wizard");
        Debug.Log("Think of a number between " + min + " and " + max + " and I will try to guess what is it.");
        Debug.Log("I will make a guess and you will tell me if my guess was too high or too low.");
        Debug.Log("Press Up arrow key for higher, press Down arrow key for lower, and Enter if I guess corrected.");
        Debug.Log("My first guess is " + guess);
        max += 1;
    }

    private void Update()
    {
        
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("My guess is " + guess);
            min = guess;
            NextGuess();
        }
        else if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("My guess is " + guess);
            max = guess;
            NextGuess();
        }
        else if(Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("I am a gen-ius!");
        }
    }

    private void NextGuess()
    {
        guess = (max + min) / 2;
    }
}