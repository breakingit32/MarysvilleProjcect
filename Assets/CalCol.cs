using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalCol : MonoBehaviour
{
    public bool rentPaid = false;
    public bool foodPaid = false;
    public bool utilitesPaid = false;
    public bool carInsurancePaid = false;
    public bool gaspaid = false;
    public bool internetPaid = false;

    public float rent;
    public float food;
    public float utilites;
    public float carInsurance;
    public float gas;
    public float internet;
    

    public CalCol(bool rentPaid, bool foodPaid, bool utilitesPaid, bool carInsurancePaid, bool gaspaid, bool internetPaid, float rent, float food, float utilites, float carInsurance, float gas, float internet)
    {
        this.rentPaid = rentPaid;
        this.foodPaid = foodPaid;
        this.utilitesPaid = utilitesPaid;
        this.carInsurancePaid = carInsurancePaid;
        this.gaspaid = gaspaid;
        this.internetPaid = internetPaid;
        this.rent = rent;
        this.food = food;
        this.utilites = utilites;
        this.carInsurance = carInsurance;
        this.gas = gas;
        this.internet = internet;
    }

    public float Cal()
    {
        if (rentPaid == true) rent = 0f;
        if (foodPaid == true) food = 0f;
        if (utilitesPaid == true) utilites = 0f;
        if (carInsurancePaid == true) carInsurance = 0f;
        if (gaspaid == true) gas = 0f;
        if (internetPaid == true) internet = 0f;

        float total = rent + food + utilites + carInsurance + gas + internet;
        Debug.Log(total);

        return total;
    }

    public float CheckBal(Player player, float item)
    {
        player.PayCheck = player.PayCheck - item;
        if (player.PayCheck >= 0f) {
            
            return 1; //Not enough funds
        }
        else { return 0; } //Has funds

        

        
    }
    public float CalChecking(Player player)
    {
        Cal();

        float checking = player.PayCheck - rent - utilites - carInsurance - gas - internet - food;      
        return checking;
    }

    public void UpdateVar(float newRent, float newFood, float newUtilites, float newCarInsurance, float newGas,  float newInternet)
    {
        rent = newRent;
        food = newFood;
        utilites = newUtilites;
        carInsurance = newCarInsurance;
        gas = newGas;
        internet = newInternet;
    }

   







    // Start is called before the first frame update

}
