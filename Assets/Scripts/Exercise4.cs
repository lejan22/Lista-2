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
        //Choosing the correct option will give us one point
        if (opt == PCschoice) 
        {
            CorrectOption++;
        }
        //Next question when we chose one option, when we arrive to the last one we don't continue
        if (question < 9) 
        {
            question++;
            PcChoices();
            Nextquestion();
        }

       
    }




    
}

