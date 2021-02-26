using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{

    [Header("UI Variables")]
    [SerializeField]
    private Text nuggetSpeech;
    [Header("Inventory Variables")]
    [SerializeField]
    private InventoryManager inventory;

    [Header("UI Text Variables")]
    [SerializeField]
    private string initialText;
    [SerializeField]
    private string successText;
    // Start is called before the first frame update
    void Start()
    {
        nuggetSpeech.text = initialText;
    }

    // Update is called once per frame
    void Update()
    {
        if (inventory.GetAllGearsPlaced())
        {
            nuggetSpeech.text = successText;
        }
        else
        {
            nuggetSpeech.text = initialText;
        }
    }

    public void ResetGame()
    {
        SceneManager.LoadScene("TesteCrenix");
    }
}
