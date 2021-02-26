using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GearSlot : MonoBehaviour
{
    [SerializeField]
    private int id;
    [SerializeField]
    private bool isFromInventory;
    [SerializeField]
    private GameObject GearPlaced;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public int GetId()
    {
        return id;
    }
    public void SetGearPlaced(GameObject gear)
    {
        GearPlaced = gear;
    }
    public GameObject GetGearPlaced()
    {
        return GearPlaced;
    }
    public bool GetIfItsFromInventory()
    {
        return isFromInventory;
    }
}
