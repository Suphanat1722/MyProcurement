using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    private int cerrentTurn; // 1-4

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
