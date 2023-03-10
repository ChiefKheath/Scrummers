using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProductObject : MonoBehaviour
{
    [SerializeField] string productName; //Name of the product
    [SerializeField] string productDesc; //Description of object

    [SerializeField] int productID; //ID number of product
    [SerializeField] double productPrice; //Price of the product

    [SerializeField] int productQuant; //How many is in stock

    [SerializeField] Image productIcon; //Image of the product
}
