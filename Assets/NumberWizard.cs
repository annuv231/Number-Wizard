using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    // Start is called before the first frame update
    int Min, Max, guess;
    void Start()
    {

        StartGame();
       // guess = 500;
    }
    void StartGame()
    {
        Min = 1;
        Max = 1000;
        guess = 500;

        Debug.Log("Welcome to the Number wizard, Yooo");
        Debug.Log("Pick a the highest number " + Max);
        Debug.Log("pick the minimum number " + Min);
        Debug.Log("Is your Number is " + guess);
        Debug.Log("Push up= Higher, Push Down = Lower, Push Enter = if its correct");
    }

    // Update is called once per frame
    void Update()
    {
        //Detect when the up arrow key is pressed down
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
           
            Debug.Log("Is it Higher?");
            Min = guess;
            MakeGuess();
            Debug.Log(guess);

        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
           
            Debug.Log("Is it Lower?");
            Max = guess;
            // guess = (Min + Max) / 2;
            MakeGuess();
            Debug.Log(guess);

        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Lmao, Im Genius. SO correct number is "+ guess);
            Start();
        }
    }
    void MakeGuess()
    {
        guess = (Min + Max) / 2;
    }
}
