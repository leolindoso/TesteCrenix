using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class GearDragHandler : MonoBehaviour, IDragHandler, IEndDragHandler
{
    [SerializeField]
    private Transform canvas;
    private Vector2 initialPos;

    void Start()
    {
        canvas = GameObject.Find("Canvas").transform;
        initialPos = transform.position;
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
    }
    public void OnEndDrag(PointerEventData eventData)
    {
        GearGenericScript gearGenericScript = GetComponent<GearGenericScript>();

        GameObject auxGear = gearGenericScript.InstantiateGear();
        if (auxGear)
        {
            // auxGear.transform.SetParent(canvas);
            Destroy(gameObject);
        }
        else
        {
            transform.position = initialPos;
        }
    }

}