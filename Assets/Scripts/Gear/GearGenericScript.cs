using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GearGenericScript : MonoBehaviour
{
    [SerializeField] private GameObject gearObject;
    [SerializeField] private GameObject gearButton;
    [SerializeField] private GearSlot gearSlot;
    [SerializeField] private InventoryManager inventory;
    [SerializeField] private bool isButton;
    [Header("General Variables")]
    [SerializeField] private Gear gear;
    [SerializeField] private GearSlot currentSlot;

    // Start is called before the first frame update
    void Start()
    {
        inventory = GameObject.Find("InventoryManager").GetComponent<InventoryManager>();
        // gear = GameObject.FindGameObjectWithTag(gameObject.tag);
    }

    // Update is called once per frame
    void Update()
    {
    }


    public void Use()
    {


    }

    public void SetCurentSlot(GearSlot gearSlot)
    {
        currentSlot = gearSlot;
    }
    public GameObject GetGearSlot()
    {
        return gearSlot.gameObject;
    }
    public GameObject GetGearButton()
    {
        return gearButton;
    }
    public GameObject GetGearObject()
    {
        return gearObject;
    }

    public GameObject InstantiateGear()
    {
        if (gearSlot)
        {

            int index = gearSlot.GetId() - 1;
            GameObject auxGear = null;
            if (gearSlot.GetIfItsFromInventory())
            {

                if (!inventory.GetArraySlotsInventoryFull()[index] && !gearSlot.GetGearPlaced())
                {

                    auxGear = Instantiate(gearButton, gearSlot.transform);
                    gearSlot.SetGearPlaced(auxGear);
                    inventory.AddItemToInventory(index, auxGear);
                    inventory.DeleteGearFromSlots(currentSlot.GetId() - 1, gear.GetGearColor());
                    auxGear.GetComponent<GearGenericScript>().SetCurentSlot(gearSlot);
                    return auxGear;
                }
                return null;
            }
            else
            {
                if (!inventory.GetArraySlotsFull()[index] && !gearSlot.GetGearPlaced())
                {
                    auxGear = Instantiate(gearObject, gearSlot.transform);
                    inventory.DeleteGearFromInventory(currentSlot.GetId() - 1, gear.GetGearColor());
                    inventory.AddItemToSlots(index, auxGear);
                    auxGear.GetComponent<GearGenericScript>().SetCurentSlot(gearSlot);
                    return auxGear;
                }
                return null;
            }
        }
        return null;
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (isButton)
        {
            if (other.CompareTag("GearSlot"))
            {
                gearSlot = other.gameObject.GetComponent<GearSlot>();
            }
        }
        else
        {
            if (other.CompareTag("GearInventorySlot"))
            {
                gearSlot = other.gameObject.GetComponent<GearSlot>();
            }
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("GearSlot") || (other.CompareTag("GearInventorySlot")))
        {
            gearSlot = null;
        }
    }
}
