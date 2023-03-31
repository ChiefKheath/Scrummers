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
        string template = "{0} {1}, {2}, £{3}";

        string[,] phoneInfo = new string[18, 4] {
            {"iPhone","X","64gb", "500"},
            {"iPhone","XR","64gb", "500"},
            {"iPhone","14","128gb", "500"},
            {"Samsung","Galaxy S21","128gb", "500"},
            {"Samsung","Galaxy S20","128gb", "500"},
            {"Samsung","Galaxy S10","128gb", "500"},
            {"Google","Pixel 6","128gb", "500"},
            {"Google","Pixel 5","128gb", "500"},
            {"Google","Pixel 4","64gb", "500"},
            {"OnePlus","9 Pro","256gb", "500"},
            {"OnePlus","8T","256gb", "500"},
            {"OnePlus","Nord 2","128gb", "500"},
            {"Xiaomi","Mi 11","128gb", "500"},
            {"Xiaomi","Mi 10","128gb", "500"},
            {"Xiaomi","Redmi Note 10 Pro","128gb", "500"},
            {"Sony","Xperia 1 III","256gb", "500"},
            {"Sony","Xperia 5 III","128gb", "500"},
            {"LG","Velvet","128gb", "500"}
        };

        string[,] simInfo = new string[17, 4] {
            {"Vodafone","SIM Only","10GB", "40"},
            {"O2","SIM Only","20GB", "40"},
            {"Three","SIM Only","Unlimited data", "40"},
            {"EE","SIM Only","15GB", "40"},
            {"BT Mobile","SIM Only","30GB", "40"},
            {"Virgin Media","SIM Only","20GB", "40"},
            {"Sky Mobile","SIM Only","25GB", "40"},
            {"Plusnet Mobile","SIM Only","10GB", "40"},
            {"iD Mobile","SIM Only","20GB", "40"},
            {"Tesco Mobile","SIM Only","15GB", "40"},
            {"Asda Mobile","SIM Only","20GB", "40"},
            {"Smarty","SIM Only","Unlimited data", "40"},
            {"giffgaff","SIM Only","40GB", "40"},
            {"VOXI","SIM Only","20GB", "40"},
            {"Lebara","SIM Only","10GB", "40"},
            {"Lycamobile","SIM Only","15GB", "40"},
            {"Superdrug Mobile","SIM Only","10GB", "40"}
        };

        string[,] accessoriesInfo = new string[20, 4] {
            {"Apple","AirPods","2nd generation", "200"},
            {"Samsung","Wireless Charger","with cooling fan", "200"},
            {"Sony","Noise Cancelling Headphones","WH-1000XM4", "200"},
            {"Belkin","Power Bank","10000mAh", "200"},
            {"Anker","Wireless Charging Stand","with USB-C", "200"},
            {"Logitech","Wireless Mouse","MX Master 3", "200"},
            {"AmazonBasics","HDMI Cable","10 feet", "200"},
            {"Jabra","Bluetooth Earbuds","Elite 75t", "200"},
            {"Fitbit","Smart Watch","Versa 3", "200"},
            {"Beats","Wireless Earphones","Powerbeats Pro", "200"},
            {"Bose","Portable Speaker","SoundLink Micro", "200"},
            {"Mophie","Wireless Charging Pad","for iPhone", "200"},
            {"Razer","Gaming Mousepad","Firefly Hard V2", "200"},
            {"Google","Chromecast","with Google TV", "200"},
            {"DJI","Pocket 2","4K camera", "200"},
            {"Aukey","USB-C Hub","7-in-1 adapter", "200"},
            {"SanDisk","MicroSD Card","128GB", "200"},
            {"UGREEN","Phone Stand","adjustable", "200"},
            {"Native Union","USB-A to Lightning Cable","Belt Cable", "200"},
            {"Nomad","Leather Phone Case","for iPhone 13", "200"}
        };

        string[,] tabletsInfo = new string[20, 4] {
            {"Apple","iPad","10.2 inch, 64GB", "500"},
            {"Samsung","Galaxy Tab S7","11 inch, 128GB", "500"},
            {"Microsoft","Surface Pro 7","12.3 inch, 128GB", "500"},
            {"Amazon","Fire HD 10","10.1 inch, 32GB", "500"},
            {"Lenovo","Tab P11 Pro","11.5 inch, 128GB", "500"},
            {"Huawei","MatePad Pro","12.6 inch, 256GB", "500"},
            {"Google","Pixel Slate","12.3 inch, 64GB", "500"},
            {"Asus","ZenPad S8","8 inch, 32GB", "500"},
            {"Sony","Xperia Z4","10.1 inch, 32GB", "500"},
            {"Samsung","Galaxy Tab A7","10.4 inch, 64GB", "500"},
            {"Apple","iPad Air","10.9 inch, 64GB", "500"},
            {"Amazon","Fire HD 8","8 inch, 32GB", "500"},
            {"Lenovo","Tab M10 Plus","10.3 inch, 128GB", "500"},
            {"Huawei","MatePad T10s","10.1 inch, 64GB", "500"},
            {"Samsung","Galaxy Tab S6 Lite","10.4 inch, 64GB", "500"},
            {"Microsoft","Surface Go 2","10.5 inch, 64GB", "500"},
            {"Google","Nexus 9","8.9 inch, 32GB", "500"},
            {"Asus","Transformer Pad","10.1 inch, 32GB", "500"},
            {"Sony","Xperia Z2","10.1 inch, 16GB", "500"},
            {"Apple","iPad Pro","11 inch, 128GB", "500"}
        };

        string[,] tvAndBroadbandInfo = new string[20, 4] {
            {"Sky","Ultimate TV","Netflix & Sky Go included", "10"},
            {"Virgin Media","Maxit TV","Free Amazon Prime Video & Netflix trial", "10"},
            {"BT TV","Entertainment","BT Sport & AMC included", "10"},
            {"NOW TV","Entertainment Pass","Sky channels & over 300 box sets", "10"},
            {"TalkTalk TV","Entertainment","Free 7-day catch up & pause/rewind live TV", "10"},
            {"EE TV","Max","Freeview channels & Apple TV app", "10"},
            {"Plusnet TV","Entertainment","Free BT Sport Lite & 20 premium channels", "10"},
            {"Vodafone TV","Entertainment","Netflix & Amazon Prime Video included", "10"},
            {"Freesat","4K TV Box","170 channels & on-demand players", "10"},
            {"Virgin Media","M350","362Mbps average download speed", "10"},
            {"BT Broadband","Fibre 2","67Mbps average download speed", "10"},
            {"Sky Broadband","Superfast","59Mbps average download speed", "10"},
            {"TalkTalk","Faster Fibre","38Mbps average download speed", "10"},
            {"NOW Broadband","Brilliant Broadband","11Mbps average download speed", "10"},
            {"Plusnet","Fibre Extra","66Mbps average download speed", "10"},
            {"EE Broadband","Fibre Plus","67Mbps average download speed", "10"},
            {"Vodafone Broadband","Pro","63Mbps average download speed", "10"},
            {"Hyperoptic","Hyperfast","1Gbps average download speed", "10"},
            {"Gigaclear","Full Fibre","900Mbps average download speed", "10"},
            {"Community Fibre","Ultrafast","400Mbps average download speed", "10"}
        };

        if (phoneGridLayoutGroup != null)
        {
            Populate(phoneInfo, phoneGridLayoutGroup, template);
        }

        if (simOnlyGridLayoutGroup != null)
        {
            Populate(simInfo, simOnlyGridLayoutGroup, template);
        }

        if (accessoriesGridLayoutGroup != null)
        {
            Populate(accessoriesInfo, accessoriesGridLayoutGroup, template);
        }

        if (tabletsGridLayoutGroup != null)
        {
            Populate(tabletsInfo, tabletsGridLayoutGroup, template);
        }

        if (tvAndBroadbandGridLayoutGroup != null)
        {
            Populate(tvAndBroadbandInfo, tvAndBroadbandGridLayoutGroup, template);
        }
    }

    private void Populate(string[,] array, GridLayoutGroup layoutGroup, string template)
    {
        for (int row = 0; row < array.GetLength(0); row++)
        { // iterate through rows
            string[] product = new string[4];
            product[0] = array[row, 0];
            product[1] = array[row, 1];
            product[2] = array[row, 2];
            product[3] = array[row, 3];
            GameObject newItem = Instantiate(itemPrefab);
            newItem.transform.SetParent(layoutGroup.transform);
            newItem.GetComponentInChildren<TMP_Text>().text = string.Format(template, product);
        }
    } 
}
