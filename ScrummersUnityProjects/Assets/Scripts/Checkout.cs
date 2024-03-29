using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkout : MonoBehaviour
{
    public GameObject CheckoutUI;
    public GameObject PaymentUI;
    public GameObject ProceedButton;
    public GameObject Filter;
    public GameObject UnavailableBox;
    //public bool CUIisUP = true;
    //public bool PUIisUP = false;

    public void PayClick()
    {
        //CUIisUP = !CUIisUP;
        //PUIisUP = !PUIisUP;
        CheckoutUI.SetActive(false);
        PaymentUI.SetActive(true);
    }

    public void Update()
    {
        if (PaymentUI == false)
        {
            ProceedButton.SetActive(false);
        }
        else if (CheckoutUI == false)
        {
            ProceedButton.SetActive(true);
        }



        if (PaymentUI == true)
        {
            Filter.SetActive(false);
            UnavailableBox.SetActive(false);
        }
        else if (CheckoutUI == true)
        {
            Filter.SetActive(false);
            UnavailableBox.SetActive(false);
        }
        else
        {
            Filter.SetActive(true);
            UnavailableBox.SetActive(true);
        }
    }

}
