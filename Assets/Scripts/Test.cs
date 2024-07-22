using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    private int cerrentDay = 1; // 10 day
    private int cerrentTurn = 1; // 1-4 turn

    private int halth = 10;
    private int bargain = 10;
    private int reliability = 10;
    private int nervous = 10;

    public GameObject averagePrice;
    private bool isPressAPbutton;

    void Start()
    {
        cerrentTurn = 1;
    }

    
    void Update()
    {
        if (cerrentDay == 10)
        {
            Debug.Log("Score summary");
        }
        else
        {
            if (cerrentDay > 1)
            {
                //Random card transport
            }
            else
            {
                //Random card PR
            }
        }


        if (isPressAPbutton)
        {
            averagePrice.SetActive(true);
        }
        else
        {
            averagePrice.SetActive(false);
        }
        
    }

    public void PressAveragePriceButton()
    {
        if (!isPressAPbutton)
        {
            isPressAPbutton = true;
        }
        else
        {
            isPressAPbutton = false;
        }  
    }


}
