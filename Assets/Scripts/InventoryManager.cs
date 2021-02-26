using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    [Header("Slots Management Variables")]
    [SerializeField] private bool[] arraySlotsFull;
    [SerializeField] private bool[] arraySlotsInventoryFull;
    [Header("Gears Inventory Variables")]
    [SerializeField] private bool hasPinkGear;
    [SerializeField] private bool hasGreenGear;
    [SerializeField] private bool hasYellowGear;
    [SerializeField] private bool hasBlueGear;
    [SerializeField] private bool hasPurpleGear;
    [Header("Gear Placed Variables")]
    [SerializeField] private bool pinkGearPlaced;
    [SerializeField] private bool greenGearPlaced;
    [SerializeField] private bool yellowGearPlaced;
    [SerializeField] private bool blueGearPlaced;
    [SerializeField] private bool purpleGearPlaced;
    [SerializeField] private bool allGearsPlaced;
    [Header("Gear Slots Variables")]
    [SerializeField] private GameObject[] upperSlots;
    [SerializeField] private GameObject[] lowerSlots;
    // Start is called before the first frame update
    void Start()
    {
        // arrayButtonSlots = new GameObject[5];
        // arraySlotsFull = new bool[5];
        // arraySlotsInventoryFull = new bool[5];
    }

    // Update is called once per frame
    void Update()
    {
        if (blueGearPlaced && greenGearPlaced && pinkGearPlaced && yellowGearPlaced && purpleGearPlaced)
        {
            StartRotation();
            allGearsPlaced = true;
        }
        else
        {
            allGearsPlaced = false;
        }
    }
    public bool GetIfPinkGearIsOnInventory()
    {
        return hasPinkGear;
    }
    public bool GetIfGreenGearIsOnInventory()
    {
        return hasGreenGear;
    }
    public bool GetIfYellowGearIsOnInventory()
    {
        return hasYellowGear;
    }
    public bool GetIfBlueGearIsOnInventory()
    {
        return hasBlueGear;
    }
    public bool GetIfPurpleGearIsOnInventory()
    {
        return hasPurpleGear;
    }
    public bool GetAllGearsPlaced()
    {
        return allGearsPlaced;
    }
    public bool[] GetArraySlotsInventoryFull()
    {
        return arraySlotsInventoryFull;
    }
    public bool[] GetArraySlotsFull()
    {
        return arraySlotsFull;
    }


    public void DeleteGearFromInventory(int index, GearColor gearColor)
    {

        switch (gearColor)
        {
            case GearColor.Pink:
                if (hasPinkGear)
                {
                    arraySlotsInventoryFull[index] = false;
                    pinkGearPlaced = true;
                    hasPinkGear = false;
                }
                break;
            case GearColor.Green:
                if (hasGreenGear)
                {
                    arraySlotsInventoryFull[index] = false;
                    greenGearPlaced = true;
                    hasGreenGear = false;
                }
                break;
            case GearColor.Yellow:
                if (hasYellowGear)
                {
                    arraySlotsInventoryFull[index] = false;
                    yellowGearPlaced = true;
                    hasYellowGear = false;
                }
                break;
            case GearColor.Blue:
                if (hasBlueGear)
                {
                    arraySlotsInventoryFull[index] = false;
                    blueGearPlaced = true;
                    hasBlueGear = false;
                }
                break;
            case GearColor.Purple:
                if (hasPurpleGear)
                {
                    arraySlotsInventoryFull[index] = false;
                    purpleGearPlaced = true;
                    hasPurpleGear = false;
                }
                break;
        }
    }
    public void DeleteGearFromSlots(int index, GearColor gearColor)
    {

        switch (gearColor)
        {
            case GearColor.Pink:
                if (hasPinkGear)
                {
                    arraySlotsFull[index] = false;
                    pinkGearPlaced = false;
                    hasPinkGear = true;
                }
                break;
            case GearColor.Green:
                if (hasGreenGear)
                {
                    arraySlotsFull[index] = false;
                    greenGearPlaced = false;
                    hasGreenGear = true;
                }
                break;
            case GearColor.Yellow:
                if (hasYellowGear)
                {
                    arraySlotsFull[index] = false;
                    yellowGearPlaced = false;
                    hasYellowGear = true;
                }
                break;
            case GearColor.Blue:
                if (hasBlueGear)
                {
                    arraySlotsFull[index] = false;
                    blueGearPlaced = false;
                    hasBlueGear = true;
                }
                break;
            case GearColor.Purple:
                if (hasPurpleGear)
                {
                    arraySlotsFull[index] = false;
                    purpleGearPlaced = false;
                    hasPurpleGear = true;
                }
                break;
        }
    }

    public void StartRotation()
    {
        foreach (GameObject gear in upperSlots)
        {
            gear.transform.Rotate(new Vector3(0, 0, -1));
        }
        foreach (GameObject gear in lowerSlots)
        {
            gear.transform.Rotate(new Vector3(0, 0, 1));
        }
    }


    public void AddItemToInventory(int index, GameObject gear)
    {
        if (!arraySlotsInventoryFull[index])
        {
            switch (gear.tag)
            {
                case "PinkGear":

                    if (!hasPinkGear)
                    {
                        hasPinkGear = true;
                        arraySlotsInventoryFull[index] = true;
                    }
                    break;
                case "GreenGear":

                    if (!hasGreenGear)
                    {
                        hasGreenGear = true;
                        arraySlotsInventoryFull[index] = true;
                    }
                    break;
                case "YellowGear":

                    if (!hasYellowGear)
                    {
                        hasYellowGear = true;
                        arraySlotsInventoryFull[index] = true;
                    }
                    break;
                case "BlueGear":

                    if (!hasBlueGear)
                    {
                        hasBlueGear = true;
                        arraySlotsInventoryFull[index] = true;
                    }
                    break;
                case "PurpleGear":

                    if (!hasPurpleGear)
                    {
                        hasPurpleGear = true;
                        arraySlotsInventoryFull[index] = true;
                    }
                    break;
            }
        }
    }
    public void AddItemToSlots(int index, GameObject gear)
    {
        bool exitLoop = false;
        Debug.Log("Adicionando ao Slot");

        if (!arraySlotsFull[index])
        {
            Debug.Log("Esse Slot do Array[" + index + "] ta Vazio");
            switch (gear.tag)
            {
                case "PinkGear":

                    arraySlotsFull[index] = true;
                    pinkGearPlaced = true;
                    exitLoop = true;

                    break;
                case "GreenGear":

                    arraySlotsFull[index] = true;
                    greenGearPlaced = true;
                    exitLoop = true;

                    break;
                case "YellowGear":

                    arraySlotsFull[index] = true;
                    yellowGearPlaced = true;
                    exitLoop = true;

                    break;
                case "BlueGear":

                    arraySlotsFull[index] = true;
                    blueGearPlaced = true;
                    exitLoop = true;

                    break;
                case "PurpleGear":

                    arraySlotsFull[index] = true;
                    purpleGearPlaced = true;
                    exitLoop = true;

                    break;
            }
        }
    }
}
