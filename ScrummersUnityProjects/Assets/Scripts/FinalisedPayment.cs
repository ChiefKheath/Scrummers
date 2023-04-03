using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FinalisedPayment : MonoBehaviour
{
    [SerializeField] public TMP_InputField ForName;
    [SerializeField] public TMP_InputField SurName;
    [SerializeField] public TMP_InputField Address1;
    [SerializeField] public TMP_InputField Address2;
    [SerializeField] public TMP_InputField City;
    [SerializeField] public TMP_InputField County;
    [SerializeField] public TMP_InputField Postcode;
    [SerializeField] public TMP_Text FinalPrice;
    public TMP_Text NameField;
    public TMP_Text AddressField;
    public TMP_Text PriceField;

    public string Name;
    public string Address;
    public string Price;

    public void Details()
    {
        Name = ForName.GetComponent<TMP_InputField>().text + " " + SurName.GetComponent<TMP_InputField>().text;
        NameField.GetComponent<TMP_Text>().text = Name;

        Address = Address1.GetComponent<TMP_InputField>().text + "<br>" + Address2.GetComponent<TMP_InputField>().text + "<br>" + City.GetComponent<TMP_InputField>().text + "<br>" + County.GetComponent<TMP_InputField>().text + "<br>" + Postcode.GetComponent<TMP_InputField>().text + "<br>";
        AddressField.GetComponent<TMP_Text>().text = Address;

        Price = FinalPrice.GetComponent<TMP_Text>().text;
        PriceField.GetComponent<TMP_Text>().text = "£" + Price;
    }
}
