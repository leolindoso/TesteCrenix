using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum GearColor
{
    Pink, Green, Yellow, Blue, Purple
}
[CreateAssetMenu(fileName = "Item", menuName = "Inventory/Gear")]
public class Gear : ScriptableObject
{
    [SerializeField] private GearColor color;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public GearColor GetGearColor()
    {
        return color;
    }


    public void Use()
    {
        // InventoryManager inventory = GameObject.Find("InventoryManager").GetComponent<InventoryManager>();

        // inventory.DeleteGearFromInventory(false, color);

    }
}
