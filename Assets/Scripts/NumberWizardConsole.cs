using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizardConsole : MonoBehaviour
{
    [SerializeField] int max;
    [SerializeField] int min;
    [SerializeField] TextMeshProUGUI guessText;

    int guess;
    // Start is called before the first frame update
    void Start()
    {
        DisplayGuess();
    }

    public void OnPressLower()
    {
        if(guess == min)
        {
            return;
        }
        else
        {
            max = guess - 1;
            DisplayGuess();
        }
    }
    public void OnPressHigher()
    {
        if (guess == max)
        {
            return;
        }
        else
        {
            min = guess + 1;
            DisplayGuess();
        }
    }
   
    void DisplayGuess()
    {
        guess = Random.Range(min, max + 1);
        guessText.text = guess.ToString();
    }
}
