using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PopulateProducts : MonoBehaviour
{
    [SerializeField] private GridLayoutGroup gridLayoutGroup;
    private string[,] productInfo;
    [SerializeField] private GameObject itemPrefab;

    void Awake()
    {
        string[,] productInfo = new string[18, 3] {
            {"iPhone","X","64gb"},
            {"iPhone","XR","64gb"},
            {"iPhone","14","128gb"},
            {"Samsung","Galaxy S21","128gb"},
            {"Samsung","Galaxy S20","128gb"},
            {"Samsung","Galaxy S10","128gb"},
            {"Google","Pixel 6","128gb"},
            {"Google","Pixel 5","128gb"},
            {"Google","Pixel 4","64gb"},
            {"OnePlus","9 Pro","256gb"},
            {"OnePlus","8T","256gb"},
            {"OnePlus","Nord 2","128gb"},
            {"Xiaomi","Mi 11","128gb"},
            {"Xiaomi","Mi 10","128gb"},
            {"Xiaomi","Redmi Note 10 Pro","128gb"},
            {"Sony","Xperia 1 III","256gb"},
            {"Sony","Xperia 5 III","128gb"},
            {"LG","Velvet","128gb"}
        };
        string template = "{0} {1}, {2}";

        for (int row = 0; row < productInfo.GetLength(0); row++) { // iterate through rows
            string[] product = new string[3];
            product[0] = productInfo[row, 0];
            product[1] = productInfo[row, 1];
            product[2] = productInfo[row, 2];
            GameObject newItem = Instantiate(itemPrefab);
            newItem.transform.SetParent(gridLayoutGroup.transform);
            newItem.GetComponentInChildren<TMP_Text>().text = string.Format(template, product);
        }
    }
}
