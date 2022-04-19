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
    public static bool rentPaidButtonClick = false;
    public static bool foodPaidButtonClick = false;
    public static bool utilitesPaidButtonClick = false;
    public static bool carInsurancePaidButtonClick = false;
    public static bool gaspaidButtonClick = false;
    public static bool internetPaidButtonClick = false;
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
    public float billss;
    public bool buttonPressed;
    public float checkBal;
    public bool resetBillVals;
    
    // Start is called before the first frame update
    public void Start()
    {
        resetBillVals = false;
        SetVar();
        manager.playerTracker = 0;
        month2.UpdateVar(month2.rent, month2.food, month2.utilites, month2.carInsurance, month2.gas, month2.internet);
        Debug.Log(manager.playerTracker);
    }
    //public void SetStartVar()
    //{
    //    rent = 1500;
    //    food = 100;
    //    utilites = 50;
    //    carInsurance = 130;
    //    gas = 1500;
    //    internet = 700;
    //    Debug.Log(food);
    //    ListenForButton();
    //}
    public void SetVar()
    {
        month2.rent = 1500;
        month2.food = 100;
        month2.utilites = 50;
        month2.carInsurance = 130;
        month2.gas = 1500;
        month2.internet = 700;
        Debug.Log(food);
        ListenForButton();
    }

    private void ListenForButton()
    {
        Button rent = Rent.GetComponent<Button>();
        Debug.Log(rent);
        rent.onClick.AddListener(PaidRent2);
        Button finish = Finish.GetComponent<Button>();
        finish.onClick.AddListener(Done);
        Button gas = Gas.GetComponent<Button>();
        gas.onClick.AddListener(PaidGas2);
        Button food = Food.GetComponent<Button>();
        food.onClick.AddListener(PaidFood2);
        Button utilites = Utilites.GetComponent<Button>();
        utilites.onClick.AddListener(PaidUtilities2);
        Button carInsurance = CarInsurance.GetComponent<Button>();
        carInsurance.onClick.AddListener(PaidCarInsurance2);
        Button internet = Internet.GetComponent<Button>();
        internet.onClick.AddListener(PaidInternet2);
    }


    public void PaidInternet2()
    {
        if (internetPaidButtonClick == false)
        {
            Warning.text = "";
            internetPaidButtonClick = true;
            float checkBal = month2.CheckBal(manager.players[manager.playerTracker], internet);
            Debug.Log(checkBal + "internet");
            if (checkBal == 0)
            {
                month2.internetPaid = true;
                Text text = Internet.GetComponentInChildren<Text>();
                text.text = "paid";

            }

            else if (checkBal == 1)
            {
                manager.players[manager.playerTracker].PayCheck = manager.players[manager.playerTracker].PayCheck + internet;
                StartCoroutine(Timer());
            }
            return;
        }
        if(internetPaidButtonClick == true && checkBal == 1)
        {
            StartCoroutine(Timer());
        }

        

        

    }

    
    public void PaidCarInsurance2()
    {
        if (carInsurancePaidButtonClick == false)
        {
            Warning.text = "";
            carInsurancePaidButtonClick = true;
            float checkBal = month2.CheckBal(manager.players[manager.playerTracker], carInsurance);
            if (checkBal == 0)
            {
                month2.carInsurancePaid = true;
                Text text = CarInsurance.GetComponentInChildren<Text>();
                text.text = "paid";

            }

            else if (checkBal == 1)
            {
                manager.players[manager.playerTracker].PayCheck = manager.players[manager.playerTracker].PayCheck + carInsurance;
                StartCoroutine(Timer());
            }
            return;
        }
        if(carInsurancePaidButtonClick == true && checkBal == 1)
        {
            StartCoroutine(Timer());
        }



    }
    

    public void PaidUtilities2()
    {
        if (utilitesPaidButtonClick == false)
        {
            Warning.text = "";
            utilitesPaidButtonClick = true;
            float checkBal = month2.CheckBal(manager.players[manager.playerTracker], utilites);
            if (checkBal == 0)
            {
                month2.utilitesPaid = true;
                Text text = Utilites.GetComponentInChildren<Text>();
                text.text = "paid";

            }

            else if (checkBal == 1)
            {
                manager.players[manager.playerTracker].PayCheck = manager.players[manager.playerTracker].PayCheck + utilites;
                StartCoroutine(Timer());
            }

            return;

        }
        if(utilitesPaidButtonClick == true && checkBal == 1)
        {
            StartCoroutine(Timer());
        }


    }
    
    public void PaidFood2()
    {
        if (foodPaidButtonClick == false)
        {
            Warning.text = "";
            foodPaidButtonClick = true;
            float checkBal = month2.CheckBal(manager.players[manager.playerTracker], food);
            if (checkBal == 0)
            {
                month2.foodPaid = true;
                Text text = Food.GetComponentInChildren<Text>();
                text.text = "paid";

            }
           
            else if (checkBal == 1)
            {
                manager.players[manager.playerTracker].PayCheck = manager.players[manager.playerTracker].PayCheck + food;
                StartCoroutine(Timer());
            }
            return;
        }

        if(foodPaidButtonClick == true && checkBal == 1)
        {
            StartCoroutine(Timer());
        }


    }
    
    public void PaidGas2()
    {
        if (gaspaidButtonClick == false)
        {
            gaspaidButtonClick = true;
            Warning.text = "";
            float checkBal = month2.CheckBal(manager.players[manager.playerTracker], gas);
            Debug.Log(checkBal + "gas");
            if (checkBal == 0)
            {
                month2.gaspaid = true;
                Text text = Gas.GetComponentInChildren<Text>();
                text.text = "paid";

            }
            else if (checkBal == 1)
            {
                manager.players[manager.playerTracker].PayCheck = manager.players[manager.playerTracker].PayCheck + gas;
                StartCoroutine(Timer());
            }
            return;
        }


        if(gaspaidButtonClick == true && checkBal == 1)
        {
            StartCoroutine(Timer());
        }

    }
    public void PaidRent2()
    {
        if (rentPaidButtonClick == false)
        {
            Warning.text = "";
            rentPaidButtonClick = true;
            checkBal = month2.CheckBal(manager.players[manager.playerTracker], rent);
            Debug.Log(checkBal + "L:");
            if (checkBal == 0)
            {
                month2.rentPaid = true;
                Text text = Rent.GetComponentInChildren<Text>();
                text.text = "paid";

            }
            else if (checkBal == 1)
            {
                manager.players[manager.playerTracker].PayCheck = manager.players[manager.playerTracker].PayCheck + rent;
                StartCoroutine(Timer());
            }
            

        }

        if (rentPaidButtonClick == true && checkBal == 1)
        {
            StartCoroutine(Timer());
        }


    }
   
    // Update is called once per frame
    void Update()
    {
         
        billss = month2.Cal();
    }

    public void Done()
    {
        buttonPressed = true;
        manager.playerTracker = manager.playerTracker + 1;
        if (manager.playerTracker > 4) manager.playerTracker = 0;
        //month2.Cal();SSS
        // reset();
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

        rentPaidButtonClick = false;
        gaspaidButtonClick = false;
        foodPaidButtonClick = false;
        carInsurancePaidButtonClick = false;
        internetPaidButtonClick = false;
        utilitesPaidButtonClick = false;
        //resetBillVals = true;
        //if(resetBillVals == true)
        //{
        //    SetVar();
        //    resetBillVals = false;
        //}

        
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
