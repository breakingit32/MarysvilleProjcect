using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

using UnityEngine.EventSystems;
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
    public static bool rentPaidButton = true;
    public static bool foodPaidButton = true;
    public static bool utilitesPaidButton = true;
    public static bool carInsurancePaidButton = true;
    public static bool gaspaidButton = true;
    public static bool internetPaidButton = true;
    public Manager manager;
    public Button Rent;
    public Button Finish;
    public Button Gas;
    public Button Utilites;
    public Button CarInsurance;
    public Button Food;
    public Button Internet;
    public Text Warning;
    public static Month2 M;
    public CalCol month2;
    public float checkBal;
    public float billss;
    public bool buttonPressed;
    
    // Start is called before the first frame update
    public void Start()
    {
        SetVar();
        manager.playerTracker = 0;
        month2.UpdateVar(rent, food, utilites, carInsurance, gas, internet);
        Debug.Log(manager.playerTracker);
    }
    public void SetVar()
    {
        rent = 1500;
        food = 100;
        utilites = 50;
        carInsurance = 130;
        gas = 150;
        internet = 700;
        Debug.Log(food);
        ListenForButton();
    }

    private void ListenForButton()
    {
        Button rent = Rent.GetComponent<Button>();
        Debug.Log(rent);
        //rent.onClick.AddListener(PaidRent);
        Button finish = Finish.GetComponent<Button>();
        //finish.onClick.AddListener(Done);
        Button gas = Gas.GetComponent<Button>();
        //gas.onClick.AddListener(PaidGas);
        Button food = Food.GetComponent<Button>();
        //food.onClick.AddListener(PaidFood);
        Button utilites = Utilites.GetComponent<Button>();
        //utilites.onClick.AddListener(PaidUtilities);
        Button carInsurance = CarInsurance.GetComponent<Button>();
        //carInsurance.onClick.AddListener(PaidCarInsurance);
        Button internet = Internet.GetComponent<Button>();
        //internet.onClick.AddListener(PaidInternet);
    }




    public void PaidInternet()
    {
        
        //manager.players[manager.playerTracker].PayCheck = manager.players[manager.playerTracker].PayCheck - internet;
        
        if (internetPaidButton == true)
        {
            checkBal = month2.CheckBal(manager.players[manager.playerTracker], internet);
            internetPaidButton = false;
            if (checkBal == 0)
            {
                month2.internetPaid = true;
                Text text = Internet.GetComponentInChildren<Text>();
                text.text = "paid";
                Internet.enabled = false;
            }
            else if (checkBal == 1)
            {
                manager.players[manager.playerTracker].PayCheck = manager.players[manager.playerTracker].PayCheck + internet;
                StartCoroutine(Timer());
            }
        }
        if(internetPaidButton == false)
        {
            Warning.text = "";
        }
        
        //else if (month2.internetPaid == true)
        //{
        //    manager.players[manager.playerTracker].PayCheck = manager.players[manager.playerTracker].PayCheck + internet;
        //    Warning.text = "";
        //    return;
        //}



    }

    public void PaidCarInsurance()
    {
        
        //manager.players[manager.playerTracker].PayCheck = manager.players[manager.playerTracker].PayCheck - carInsurance;
        
        if(carInsurancePaidButton == true)
        {
            carInsurancePaidButton = false;
            checkBal = month2.CheckBal(manager.players[manager.playerTracker], carInsurance);
            if (checkBal == 0)
            {
                month2.carInsurancePaid = true;
                Text text = CarInsurance.GetComponentInChildren<Text>();
                text.text = "paid";
                CarInsurance.enabled = false;
            }
            else if (checkBal == 1)
            {
                manager.players[manager.playerTracker].PayCheck = manager.players[manager.playerTracker].PayCheck + carInsurance;
                StartCoroutine(Timer());
            }
        }
        
       
        
        
    }

    public void PaidUtilities()
    {
        if(utilitesPaidButton == true)
        {
            utilitesPaidButton = false;
            checkBal = month2.CheckBal(manager.players[manager.playerTracker], utilites);
            if (checkBal == 0)
            {
                month2.utilitesPaid = true;
                Text text = Utilites.GetComponentInChildren<Text>();
                text.text = "paid";
                Utilites.enabled = false;
            }
            else if (checkBal == 1)
            {
                manager.players[manager.playerTracker].PayCheck = manager.players[manager.playerTracker].PayCheck + utilites;
                StartCoroutine(Timer());
            }
        }
        //manager.players[manager.playerTracker].PayCheck = manager.players[manager.playerTracker].PayCheck - utilites;
        
        //else if (month2.utilitesPaid == true)
        //{
        //    manager.players[manager.playerTracker].PayCheck = manager.players[manager.playerTracker].PayCheck + utilites;
        //    Warning.text = "";
        //    return;
        //}
        

        
    }

    public void PaidFood()
    {
        if(foodPaidButton == true)
        {
            foodPaidButton = false;
            checkBal = month2.CheckBal(manager.players[manager.playerTracker], food);
            //manager.players[manager.playerTracker].PayCheck = manager.players[manager.playerTracker].PayCheck - food;
            if (checkBal == 0)
            {
                month2.foodPaid = true;
                Text text = Food.GetComponentInChildren<Text>();
                text.text = "paid";
                Food.enabled = false;
            }
            else if (checkBal == 1)
            {
                manager.players[manager.playerTracker].PayCheck = manager.players[manager.playerTracker].PayCheck + food;
                StartCoroutine(Timer());
            }
        }
        
        //else if (month2.foodPaid == true)
        //{
        //    manager.players[manager.playerTracker].PayCheck = manager.players[manager.playerTracker].PayCheck + food;
        //    Warning.text = "";
        //    return;
        //}
        

        else
        {
            Warning.text = "";
        }
    }


    public void PaidGas()
    {

        if(gaspaidButton == true)
        {
            checkBal = month2.CheckBal(manager.players[manager.playerTracker], food);
            Debug.Log(checkBal + "If 0 you have money");
            if (checkBal == 0)
            {
                month2.gaspaid = true;
                Text text = Gas.GetComponentInChildren<Text>();
                text.text = "paid";
                Gas.enabled = false;
            }
            else if (checkBal == 1)
            {
                manager.players[manager.playerTracker].PayCheck = manager.players[manager.playerTracker].PayCheck + gas;
                StartCoroutine(Timer());
            }
        }
        

        
        //else if(month2.gaspaid == true)
        //{
        //    manager.players[manager.playerTracker].PayCheck = manager.players[manager.playerTracker].PayCheck + gas;
        //    Warning.text = "";
        //    return;
        //}
        
        else
        {
            Warning.text = "";
        }

    }
    public void PaidRent()
    {
        if(rentPaidButton == true)
        {
            rentPaidButton = false;
            checkBal = month2.CheckBal(manager.players[manager.playerTracker], rent);
            //manager.players[manager.playerTracker].PayCheck = manager.players[manager.playerTracker].PayCheck - rent;
            if (checkBal == 0)
            {
                month2.rentPaid = true;
                Text text = Rent.GetComponentInChildren<Text>();
                text.text = "paid";
                Rent.enabled = false;
            }
            else if (checkBal == 1)
            {
                manager.players[manager.playerTracker].PayCheck = manager.players[manager.playerTracker].PayCheck + rent;
                StartCoroutine(Timer());
            }
        }
        
        //else if (month2.rentPaid == true)
        //{
        //    manager.players[manager.playerTracker].PayCheck = manager.players[manager.playerTracker].PayCheck + rent;
        //    Warning.text = "";
        //    return;
        //}
        
    }
        // Update is called once per frame
        void Update()
    {
        float bills = month2.Cal();
        billss = bills;
    }

    public void Done()
    {
        buttonPressed = true;
        manager.playerTracker = manager.playerTracker + 1;
        if (manager.playerTracker > 4) manager.playerTracker = 0;
        //month2.Cal();SSS
        reset();
        //SceneManager.LoadScene(manager.scenes[manager.playerTracker]);
        
        Debug.Log(manager.playerTracker);
    }

    
        
        
    
    public void reset()
    {
        bool rentP = month2.rentPaid == true ? false : false;
        bool gasP = month2.gaspaid == true ? false : false;
        bool internetP = month2.internetPaid == true ? false : false;
        bool foodP = month2.foodPaid == true ? false : false;
        bool utilitesP = month2.utilitesPaid == true ? false : false;
        bool carInsuranceP = month2.carInsurancePaid == true ? false : false;

        Rent.enabled = true;
        Utilites.enabled = true;
        Gas.enabled = true;
        Internet.enabled = true;
        CarInsurance.enabled = true;
        Food.enabled = true;

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

    public IEnumerator Timer()
    {
        Warning.text = "Incifienant Funds";
        yield return new WaitForSeconds(5);
        Warning.text = "";

        
    }
}
