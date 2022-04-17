using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextManager : MonoBehaviour
{
    public Text Savings;
    public Text Checking;
    public Text Col;
    public float bills;
    public Month2 month2;
    public Manager manager;
    
    // Start is called before the first frame update
    void Start()
    {
        
        Text Col = GetComponent<Text>();
        Text Checking = GetComponent<Text>();
    }

    void Update()
    {
        Checking.text = "CARSS";// "Checking: $" + manager.players[manager.playerTracker].PayCheck.ToString();
        Debug.Log(manager.players[manager.playerTracker].PayCheck + "CCCC");
        Col.text = "Bills: $"+ month2.billss.ToString();

    }


}
