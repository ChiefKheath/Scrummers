using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Basket : MonoBehaviour
{
    public GameObject basketUI;
    public bool UIisUP = false;
    [SerializeField] private GridLayoutGroup basketGridView;
    [SerializeField] public BasketItems basketItems;
    [SerializeField] private GameObject itemPrefab;
    [SerializeField] private GameObject emptyBasketPrefab;
    [SerializeField] private GameObject checkoutButton;
    [SerializeField] public GameObject basketButton;
    [SerializeField] public TMP_Text basketButtonTxt;
    [SerializeField] private GameObject mobilePhonesScrollView, simOnlyScrollView, accessoriesScrollView, tabletsScrollView, tvAndBroadbandScrollView, supportScrollView, checkout, basketBox, checkoutPayment, checkoutDetails;
    [SerializeField] public PopulateCheckout populateCheckout;
    Color blue;

    public void BasketClick()
    {
        UIisUP = !UIisUP;
        basketUI.SetActive(UIisUP);

        ClearBasket();

        if (basketItems.items.Count == 0)
        {
            GameObject emptyBasketItem = Instantiate(emptyBasketPrefab);
            emptyBasketItem.transform.SetParent(basketGridView.transform);
            basketButtonTxt.text = "Basket";
            basketButton.GetComponent<Image>().color = blue;
            checkoutButton.SetActive(false);
        }
        else
        {
            foreach (GameObject item in basketItems.items)
            {
                string info = item.GetComponentInChildren<TMP_Text>().text;
                GameObject basketItem = Instantiate(itemPrefab);
                basketItem.transform.SetParent(basketGridView.transform);
                basketItem.GetComponentInChildren<TMP_Text>().text = info;
            }
            checkoutButton.SetActive(true);
        }
    }

    private void ClearBasket()
    {
        foreach (Transform child in basketGridView.transform)
        {
            Destroy(child.gameObject);
        }
    }

    public void CloseBasket()
    {
            basketUI.SetActive(false);
            UIisUP = false;
    }
    public void Checkout()
    {
        SetAllInactive();
        checkout.SetActive(true);
        checkoutDetails.SetActive(true);
        CloseBasket();

        populateCheckout.Populate();
        populateCheckout.CalculateTotal();
    }

    private void SetAllInactive()
    {
        mobilePhonesScrollView.SetActive(false);
        simOnlyScrollView.SetActive(false);
        tabletsScrollView.SetActive(false);
        accessoriesScrollView.SetActive(false);
        tabletsScrollView.SetActive(false);
        tvAndBroadbandScrollView.SetActive(false);
        supportScrollView.SetActive(false);
        checkout.SetActive(false);
        basketBox.SetActive(false);
        checkoutPayment.SetActive(false);
        checkoutDetails.SetActive(false);

    }

    private void Start()
    {
        blue = new Color32(73, 198, 229, 255);
    }
}
