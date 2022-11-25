using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class xercise5 : MonoBehaviour
{

    public TMP_InputField birthYear;
    public TextMeshProUGUI horoscope;

    private int horoscopeIndex;

    


    

    // Start is called before the first frame update
    void Start()
    {
        //Hides answer text at the beginning
        horoscope.gameObject.SetActive(false);
    }

    //List of all the answers possible
    private string[] answers =
    {
        "Monkey",
        "Rooster",
        "Dog",
        "Pig",
        "Rat",
        "Ox",
        "Tiger",
        "Rabbit",
        "Dragon",
        "Snake",
        "Horse",
        "Goat",
    };

    


    public void CheckHoroscope()
    {
        //If there is no answer
        if (birthYear.text != null || birthYear.text != "")
        {
            //The answer appears
            horoscope.gameObject.SetActive(true);
            //You'll get the answer depending on what you wrote, diving the year in 12
            horoscopeIndex = int.Parse(birthYear.text) % 12;

            horoscope.text = answers[horoscopeIndex];
        }
    }

}
