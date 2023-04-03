using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CardChecker : MonoBehaviour
{
    public TMP_InputField CardNumberField;
    public Button finalise;
    public TMP_InputField CVCField;
    public GameObject finalisedpayment;

    public void CardNumberCheck()
    {
        if (CardNumberField.text.Length < 16)
        {
            Debug.Log("tooshort");
        }
        else if (CardNumberField.text.Length == 16)
        {
            Debug.Log("Perfecto");
        }
    }
    public void CVCCheck()
    {
        if (CVCField.text.Length < 3)
        {
            Debug.Log("tooshort");
        }
        else if (CVCField.text.Length == 3)
        {
            Debug.Log("Perfecto");
        }
    }

    public void FinalisePayment()
    {
        if (CardNumberField.text.Length == 16 && CVCField.text.Length == 3)
        {
            finalisedpayment.SetActive(true);
        }
    }
}
