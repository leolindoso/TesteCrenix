using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GearObject : MonoBehaviour
{

    [Header("Gear Variables")]
    [SerializeField] private string itemName;
    [SerializeField] private string tagName;
    [Header("UI Variables")]
    [SerializeField] private GameObject gearButton;
    // [SerializeField] private Text nameText;
    // [SerializeField] private Text descriptionText;
    [SerializeField] private InventoryManager inventory;
    // [TextArea(5,10)][SerializeField] private string description;
    [Header("General Variables")]
    [SerializeField] private Gear gear;




    // Start is called before the first frame update
    void Start()
    {
        tagName = gameObject.tag;
        inventory = GameObject.Find("InventoryManager").GetComponent<InventoryManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public string GetItemName()
    {
        return itemName;
    }
    public Gear GetGear()
    {
        return gear;
    }
    // public void AddGearToInvetory()
    // {
    //     inventory.AddItemToInventory(gameObject);
    // }
}
