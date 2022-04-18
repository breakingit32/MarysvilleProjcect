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
    public CalCol cal;
    public Text Player;
    public string Savingsss;
    
    // Start is called before the first frame update
    void Start()
    {
        Text Player = GetComponent<Text>();
        Text Col = GetComponent<Text>();
        Text Checking = GetComponent<Text>();
        Text Savings = GetComponent<Text>();
        Savingsss = manager.players[1].Savings.ToString();
    }

    void Update()
    {
        Player.text = "Player: " + (manager.playerTracker + 1).ToString();
        Debug.Log(cal.CalChecking(manager.players[manager.playerTracker]) + "((((");
        Checking.text = "Checking: $" + cal.CalChecking(manager.players[manager.playerTracker]).ToString(); 
        Debug.Log(manager.players[manager.playerTracker].PayCheck + "CCCC");
        Col.text = "Bills: $" + month2.billss.ToString();
        Savings.text = "Savings: $" + Savingsss;
        

    }


}
