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
    // Start is called before the first frame update
    void Start()
    {
        
        Text Col = GetComponent<Text>();
    }

    void Update()
    {
        
        Col.text = "Bills: $"+ month2.billss.ToString();
    }


}
