using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PopulateProducts : MonoBehaviour
{
    [SerializeField] private GridLayoutGroup phoneGridLayoutGroup;
    [SerializeField] private GridLayoutGroup simOnlyGridLayoutGroup;
    [SerializeField] private GridLayoutGroup accessoriesGridLayoutGroup;
    [SerializeField] private GridLayoutGroup tabletsGridLayoutGroup;
    [SerializeField] private GridLayoutGroup tvAndBroadbandGridLayoutGroup;
    [SerializeField] private GameObject itemPrefab;

    void Awake()
    {        
        string template = "{0} {1}, {2}";

        string[,] phoneInfo = new string[18, 3] {
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

        if(phoneGridLayoutGroup != null)
        {
            for (int row = 0; row < phoneInfo.GetLength(0); row++)
            { // iterate through rows
                string[] product = new string[3];
                product[0] = phoneInfo[row, 0];
                product[1] = phoneInfo[row, 1];
                product[2] = phoneInfo[row, 2];
                GameObject newItem = Instantiate(itemPrefab);
                newItem.transform.SetParent(phoneGridLayoutGroup.transform);
                newItem.GetComponentInChildren<TMP_Text>().text = string.Format(template, product);
            }
        }

        string[,] simInfo = new string[17, 3] {
            {"Vodafone","SIM Only","10GB"},
            {"O2","SIM Only","20GB"},
            {"Three","SIM Only","Unlimited data"},
            {"EE","SIM Only","15GB"},
            {"BT Mobile","SIM Only","30GB"},
            {"Virgin Media","SIM Only","20GB"},
            {"Sky Mobile","SIM Only","25GB"},
            {"Plusnet Mobile","SIM Only","10GB"},
            {"iD Mobile","SIM Only","20GB"},
            {"Tesco Mobile","SIM Only","15GB"},
            {"Asda Mobile","SIM Only","20GB"},
            {"Smarty","SIM Only","Unlimited data"},
            {"giffgaff","SIM Only","40GB"},
            {"VOXI","SIM Only","20GB"},
            {"Lebara","SIM Only","10GB"},
            {"Lycamobile","SIM Only","15GB"},
            {"Superdrug Mobile","SIM Only","10GB"}
        };

        if(simOnlyGridLayoutGroup != null)
        {
            for (int row = 0; row < simInfo.GetLength(0); row++)
            { // iterate through rows
                string[] product = new string[3];
                product[0] = simInfo[row, 0];
                product[1] = simInfo[row, 1];
                product[2] = simInfo[row, 2];
                GameObject newItem = Instantiate(itemPrefab);
                newItem.transform.SetParent(simOnlyGridLayoutGroup.transform);
                newItem.GetComponentInChildren<TMP_Text>().text = string.Format(template, product);
            }
        }
    }
}
