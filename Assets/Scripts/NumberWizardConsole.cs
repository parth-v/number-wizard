using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditorInternal;

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
            guessText.text = ("Error!");
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
            guessText.text = ("Error!");
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
