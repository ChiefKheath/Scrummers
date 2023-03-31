using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkout : MonoBehaviour
{
    public GameObject CheckoutUI;
    public GameObject PaymentUI;
    public GameObject ProceedButton;
    public bool CUIisUP = true;
    public bool PUIisUP = false;

    public void PayClick()
    {
        CUIisUP = !CUIisUP;
        PUIisUP = !PUIisUP;
        CheckoutUI.SetActive(CUIisUP);
        PaymentUI.SetActive(PUIisUP);

        if (PUIisUP == true)
        {
            ProceedButton.SetActive(false);
        }
        else if (CUIisUP == true)
        {
            ProceedButton.SetActive(true);
        }
    }

}
