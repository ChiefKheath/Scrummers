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

        string[,] accessoriesInfo = new string[20, 3] {
            {"Apple","AirPods","2nd generation"},
            {"Samsung","Wireless Charger","with cooling fan"},
            {"Sony","Noise Cancelling Headphones","WH-1000XM4"},
            {"Belkin","Power Bank","10000mAh"},
            {"Anker","Wireless Charging Stand","with USB-C"},
            {"Logitech","Wireless Mouse","MX Master 3"},
            {"AmazonBasics","HDMI Cable","10 feet"},
            {"Jabra","Bluetooth Earbuds","Elite 75t"},
            {"Fitbit","Smart Watch","Versa 3"},
            {"Beats","Wireless Earphones","Powerbeats Pro"},
            {"Bose","Portable Speaker","SoundLink Micro"},
            {"Mophie","Wireless Charging Pad","for iPhone"},
            {"Razer","Gaming Mousepad","Firefly Hard V2"},
            {"Google","Chromecast","with Google TV"},
            {"DJI","Pocket 2","4K camera"},
            {"Aukey","USB-C Hub","7-in-1 adapter"},
            {"SanDisk","MicroSD Card","128GB"},
            {"UGREEN","Phone Stand","adjustable"},
            {"Native Union","USB-A to Lightning Cable","Belt Cable"},
            {"Nomad","Leather Phone Case","for iPhone 13"}
        };

        string[,] tabletsInfo = new string[20, 3] {
            {"Apple","iPad","10.2 inch, 64GB"},
            {"Samsung","Galaxy Tab S7","11 inch, 128GB"},
            {"Microsoft","Surface Pro 7","12.3 inch, 128GB"},
            {"Amazon","Fire HD 10","10.1 inch, 32GB"},
            {"Lenovo","Tab P11 Pro","11.5 inch, 128GB"},
            {"Huawei","MatePad Pro","12.6 inch, 256GB"},
            {"Google","Pixel Slate","12.3 inch, 64GB"},
            {"Asus","ZenPad S8","8 inch, 32GB"},
            {"Sony","Xperia Z4","10.1 inch, 32GB"},
            {"Samsung","Galaxy Tab A7","10.4 inch, 64GB"},
            {"Apple","iPad Air","10.9 inch, 64GB"},
            {"Amazon","Fire HD 8","8 inch, 32GB"},
            {"Lenovo","Tab M10 Plus","10.3 inch, 128GB"},
            {"Huawei","MatePad T10s","10.1 inch, 64GB"},
            {"Samsung","Galaxy Tab S6 Lite","10.4 inch, 64GB"},
            {"Microsoft","Surface Go 2","10.5 inch, 64GB"},
            {"Google","Nexus 9","8.9 inch, 32GB"},
            {"Asus","Transformer Pad","10.1 inch, 32GB"},
            {"Sony","Xperia Z2","10.1 inch, 16GB"},
            {"Apple","iPad Pro","11 inch, 128GB"}
        };

        string[,] tvAndBroadbandInfo = new string[20, 3] {
            {"Sky","Ultimate TV","Netflix & Sky Go included"},
            {"Virgin Media","Maxit TV","Free Amazon Prime Video & Netflix trial"},
            {"BT TV","Entertainment","BT Sport & AMC included"},
            {"NOW TV","Entertainment Pass","Sky channels & over 300 box sets"},
            {"TalkTalk TV","Entertainment","Free 7-day catch up & pause/rewind live TV"},
            {"EE TV","Max","Freeview channels & Apple TV app"},
            {"Plusnet TV","Entertainment","Free BT Sport Lite & 20 premium channels"},
            {"Vodafone TV","Entertainment","Netflix & Amazon Prime Video included"},
            {"Freesat","4K TV Box","170 channels & on-demand players"},
            {"Virgin Media","M350","362Mbps average download speed"},
            {"BT Broadband","Fibre 2","67Mbps average download speed"},
            {"Sky Broadband","Superfast","59Mbps average download speed"},
            {"TalkTalk","Faster Fibre","38Mbps average download speed"},
            {"NOW Broadband","Brilliant Broadband","11Mbps average download speed"},
            {"Plusnet","Fibre Extra","66Mbps average download speed"},
            {"EE Broadband","Fibre Plus","67Mbps average download speed"},
            {"Vodafone Broadband","Pro","63Mbps average download speed"},
            {"Hyperoptic","Hyperfast","1Gbps average download speed"},
            {"Gigaclear","Full Fibre","900Mbps average download speed"},
            {"Community Fibre","Ultrafast","400Mbps average download speed"}
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

        if (tvAndBroadbandInfo != null)
        {
            Populate(tvAndBroadbandInfo, tvAndBroadbandGridLayoutGroup, template);
        }
    }

    private void Populate(string[,] array, GridLayoutGroup layoutGroup, string template)
    {
        for (int row = 0; row < array.GetLength(0); row++)
        { // iterate through rows
            string[] product = new string[3];
            product[0] = array[row, 0];
            product[1] = array[row, 1];
            product[2] = array[row, 2];
            GameObject newItem = Instantiate(itemPrefab);
            newItem.transform.SetParent(layoutGroup.transform);
            newItem.GetComponentInChildren<TMP_Text>().text = string.Format(template, product);
        }
    } 
}
