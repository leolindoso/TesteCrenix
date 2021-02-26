using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    [Header("Slots Management Variables")]
    [SerializeField] private Transform[] arraySlots;
    [SerializeField] private GearSlot[] arrayButtonSlots;
    [SerializeField] private bool[] arraySlotsFull;
    [Header("Gears Inventory Variables")]
    [SerializeField] private bool hasPinkGear;
    [SerializeField] private bool hasGreenGear;
    [SerializeField] private bool hasYellowGear;
    [SerializeField] private bool hasBlueGear;
    [SerializeField] private bool hasPurpleGear;
    [Header("Gear Placed Variables")]
    [SerializeField] private bool pinkGearPlaced;
    [SerializeField] private bool greeGearPlaced;
    [SerializeField] private bool yellowGearPlaced;
    [SerializeField] private bool blueGearPlaced;
    [SerializeField] private bool purpleGearPlaced;
    [Header("Gear Slots Variables")]
    [SerializeField] private GameObject[] upperSlots;
    [SerializeField] private GameObject[] lowerSlots;
    // Start is called before the first frame update
    void Start()
    {
        // arrayButtonSlots = new GameObject[5];
        arraySlotsFull = new bool[5];
    }

    // Update is called once per frame
    void Update()
    {
        if (blueGearPlaced && greeGearPlaced && pinkGearPlaced && yellowGearPlaced && purpleGearPlaced)
        {
            StartRotation();
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
    public bool[] GetArraySlotsFull()
    {
        return arraySlotsFull;
    }


    public void DeleteGearFromInventory(int index, bool flag, GearColor gearColor)
    {
        arraySlotsFull[index] = false;
        Debug.Log(index);
        switch (gearColor)
        {
            case GearColor.Pink:
                if (hasPinkGear)
                {
                    pinkGearPlaced = true;
                    hasPinkGear = false;
                }
                break;
            case GearColor.Green:
                if (hasGreenGear)
                {
                    // for (int i = 0; i < arrayButtonSlots.Length; i++)
                    // {
                    //     if (arrayButtonSlots[i] != null && arrayButtonSlots[i].GetGearPlaced().CompareTag("GreenGear"))
                    //     {
                    //         Destroy(arrayButtonSlots[i]);
                    //         arrayButtonSlots[i] = null;
                    //         arraySlotsFull[i] = false;
                    //     }
                    // }
                    greeGearPlaced = true;
                    hasGreenGear = false;
                }
                break;
            case GearColor.Yellow:
                if (hasYellowGear)
                {
                    // for (int i = 0; i < arrayButtonSlots.Length; i++)
                    // {
                    //     if (arrayButtonSlots[i] != null && arrayButtonSlots[i].GetGearPlaced().CompareTag("YellowGear"))
                    //     {
                    //         Destroy(arrayButtonSlots[i]);
                    //         arrayButtonSlots[i] = null;
                    //         arraySlotsFull[i] = false;
                    //     }
                    // }
                    yellowGearPlaced = true;
                    hasYellowGear = false;
                }
                break;
            case GearColor.Blue:
                if (hasBlueGear)
                {
                    // for (int i = 0; i < arrayButtonSlots.Length; i++)
                    // {
                    //     if (arrayButtonSlots[i] != null && arrayButtonSlots[i].GetGearPlaced().CompareTag("BlueGear"))
                    //     {
                    //         Destroy(arrayButtonSlots[i]);
                    //         arrayButtonSlots[i] = null;
                    //         arraySlotsFull[i] = false;
                    //     }
                    // }
                    blueGearPlaced = true;
                    hasBlueGear = false;
                }
                break;
            case GearColor.Purple:
                if (hasPurpleGear)
                {
                    //     for (int i = 0; i < arrayButtonSlots.Length; i++)
                    //     {
                    //         if (arrayButtonSlots[i] != null && arrayButtonSlots[i].GetGearPlaced().CompareTag("PurpleGear"))
                    //         {
                    //             Destroy(arrayButtonSlots[i]);
                    //             arrayButtonSlots[i] = null;
                    //             arraySlotsFull[i] = false;
                    //         }
                    //     }
                    purpleGearPlaced = true;
                    hasPurpleGear = false;
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


    public void AddItemToInventory(GameObject gear)
    {
        bool exitLoop = false;
        bool gearAdded = false;
        Debug.Log("Adicionando ao inventario");
        for (int i = 0; i < arraySlotsFull.Length; i++)
        {
            if (!arraySlotsFull[i])
            {
                Debug.Log("Esse Slot[" + i + "] ta Vazio");
                switch (gear.tag)
                {
                    case "PinkGear":

                        if (!hasPinkGear)
                        {
                            // GameObject buttonObject = Instantiate(gearButton, arraySlots[i]);
                            // arrayButtonSlots[i] = buttonObject;
                            hasPinkGear = true;
                            arraySlotsFull[i] = true;
                            exitLoop = true;
                            gearAdded = true;
                        }

                        break;
                    case "GreenGear":

                        if (!hasGreenGear)
                        {
                            // GameObject buttonObject = Instantiate(gearButton, arraySlots[i]);
                            // arrayButtonSlots[i] = buttonObject;
                            hasGreenGear = true;
                            arraySlotsFull[i] = true;
                            exitLoop = true;
                            gearAdded = true;
                        }

                        break;
                    case "YellowGear":

                        if (!hasYellowGear)
                        {
                            // GameObject buttonObject = Instantiate(gearButton, arraySlots[i]);
                            // arrayButtonSlots[i] = buttonObject;
                            hasYellowGear = true;
                            arraySlotsFull[i] = true;
                            exitLoop = true;
                            gearAdded = true;
                        }

                        break;
                    case "BlueGear":

                        if (!hasBlueGear)
                        {
                            // GameObject buttonObject = Instantiate(gearButton, arraySlots[i]);
                            // arrayButtonSlots[i] = buttonObject;
                            hasBlueGear = true;
                            arraySlotsFull[i] = true;
                            exitLoop = true;
                            gearAdded = true;
                        }

                        break;
                    case "PurpleGear":

                        if (!hasPurpleGear)
                        {
                            // GameObject buttonObject = Instantiate(gearButton, arraySlots[i]);
                            // arrayButtonSlots[i] = buttonObject;
                            hasPurpleGear = true;
                            arraySlotsFull[i] = true;
                            exitLoop = true;
                            gearAdded = true;
                        }

                        break;
                }

                if (exitLoop)
                {
                    break;
                };
            }
        }
        // if (!gearAdded)
        // {
        //     switch (gear.GetItemName())
        //     {
        //         case "Red gear":
        //             redgearAmount++;
        //             break;
        //         case "White gear":
        //             whitegearAmount++;
        //             break;
        //         case "Orange gear":
        //             orangegearAmount++;
        //             break;
        //         case "Blue gear":
        //             bluegearAmount++;
        //             break;
        //         case "Black gear":
        //             blackgearAmount++;
        //             break;
        //     }
        //     Destroy(gear.gameObject);
        // }
    }
}
