using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Exercise2 : MonoBehaviour
{
    public float timer;
    private float StartTime;

    
    public Image imageBar;

    public bool canClick = true;
    // Start is called before the first frame update
    void Start()
    {
        UpdateTime();

    }

    // Update is called once per frame
    void Update()
    {
        if(timer > 0 && !canClick)
        {
            UpdateTime();
        }
    }

    public void StartButton()
    {
        if (canClick == true) 
        {
            StartTime = timer;
            
            canClick = false;
        }
    }

    public void UpdateTime()
    {
        timer -= Time.deltaTime;
        imageBar.fillAmount = timer / StartTime;
    }


}
