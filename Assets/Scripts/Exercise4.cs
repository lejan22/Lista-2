using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Exercise4 : MonoBehaviour
{
    public TextMeshProUGUI Option1text;
    public TextMeshProUGUI Option2text;

    public string[] Choice1;
    public string[] Choice2;
    

    public int PCschoice; 

   //Variable to know Which question to choose
    private int question;

    private int CorrectOption; 

    void Start()
    {
       
    }
    //PC will gladly choose one of the two options
    public void PcChoices() 
    {
        PCschoice = Random.Range(0, 2); 
    }
    //Lets go to the next question
    public void Nextquestion() 
    {
        Option1text.text = Choice1[question];
        Option2text.text = Choice2[question];
    }

    public void Choosing(int opt) 
    {
        if (opt == PCschoice) //if we have chosen the same option we add 1 point of success
        {
            CorrectOption++;
        }

        if (question < 9) //if the answer was not for the last question we can place the next two options on screen
        {
            question++;
            PcChoices();
            Nextquestion();
        }

       
    }




    
}

