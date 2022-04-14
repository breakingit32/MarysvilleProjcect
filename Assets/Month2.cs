using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Month2 : MonoBehaviour
{

    public static float rent;
    public static float food;
    public static float utilites;
    public static float carInsurance;
    public static float gas;
    public static float internet;
    public static bool rentPaid = false;
    public static bool foodPaid = false;
    public static bool utilitesPaid = false;
    public static bool carInsurancePaid = false;
    public static bool gaspaid = false;
    public static bool internetPaid = false;
    public Manager manager;
    public Button Rent;
    public Button Finish;
    public Button Gas;
    public Button Utilites;
    public Button CarInsurance;
    public Button Food;
    public Button Internet;
    public static Month2 M;
    public CalCol month2;
    public float billss;

    // Start is called before the first frame update
    public void Start()
    {
        SetVar();
        
        month2.UpdateVar(rent, food, utilites, carInsurance, gas, internet);
       
    }
    public void SetVar()
    {
        rent = 1500;
        food = 100;
        utilites = 50;
        carInsurance = 130;
        gas = 150;
        internet = 70;
        Debug.Log(food);
        ListenForButton();
    }

    private void ListenForButton()
    {
        Button rent = Rent.GetComponent<Button>();
        Debug.Log(rent);
        rent.onClick.AddListener(PaidRent);
        Button finish = Finish.GetComponent<Button>();
        finish.onClick.AddListener(Done);
        Button gas = Gas.GetComponent<Button>();
        gas.onClick.AddListener(PaidGas);
        Button food = Food.GetComponent<Button>();
        food.onClick.AddListener(PaidFood);
        Button utilites = Utilites.GetComponent<Button>();
        utilites.onClick.AddListener(PaidUtilities);
        Button carInsurance = CarInsurance.GetComponent<Button>();
        carInsurance.onClick.AddListener(PaidCarInsurance);
        Button internet = Internet.GetComponent<Button>();
        internet.onClick.AddListener(PaidInternet);
    }

    private void PaidInternet()
    {
        month2.internetPaid = true;
        Text text = Internet.GetComponentInChildren<Text>();
        text.text = "paid";
    }

    private void PaidCarInsurance()
    {
        month2.carInsurancePaid = true;
        Text text = CarInsurance.GetComponentInChildren<Text>();
        text.text = "paid";
    }

    private void PaidUtilities()
    {
        month2.utilitesPaid = true;
        Text text = Utilites.GetComponentInChildren<Text>();
        text.text = "paid";
    }

    private void PaidFood()
    {
        month2.foodPaid = true;
        Text text = Food.GetComponentInChildren<Text>();
        text.text = "paid";
    }


    private void PaidGas()
    {
        month2.gaspaid = true;
        Text text = Gas.GetComponentInChildren<Text>();
        text.text = "paid";
    }

    // Update is called once per frame
    void Update()
    {
        float bills = month2.Cal();
        billss = bills;
    }

    public void Done()
    {
        //month2.Cal();SSS
        reset();
        //SceneManager.LoadScene(manager.scenes[manager.playerTracker]);
        manager.playerTracker++;
        Debug.Log(manager.playerTracker);
    }

    public void PaidRent()
    {
        month2.rentPaid = true;
        Text text = Rent.GetComponentInChildren<Text>();
        text.text = "paid";
    }
    public void reset()
    {
        bool rentP = month2.rentPaid == true ? false : false;
        bool gasP = month2.gaspaid == true ? false : false;
        bool internetP = month2.internetPaid == true ? false : false;
        bool foodP = month2.foodPaid == true ? false : false;
        bool utilitesP = month2.utilitesPaid == true ? false : false;
        bool carInsuranceP = month2.carInsurancePaid == true ? false : false;

        Text textR = Rent.GetComponentInChildren<Text>();
        if (rentP == false) textR.text = "Rent";
        Text textG = Gas.GetComponentInChildren<Text>();
        if (gasP == false) textG.text = "Gas";
        Text textI= Internet.GetComponentInChildren<Text>();
        if (internetP == false) textI.text = "Internet";
        Text textF = Food.GetComponentInChildren<Text>();
        if (foodP == false) textF.text = "Food";
        Text textU = Utilites.GetComponentInChildren<Text>();
        if (utilitesP== false) textU.text = "Utilites";
        Text textC = CarInsurance.GetComponentInChildren<Text>();
        if (carInsuranceP == false) textC.text = "Car Insurance";


    }
}
