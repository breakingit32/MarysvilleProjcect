using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public Month2 Month2;
    public Manager manager;
    public string[] AllSitucation;
    public List<string> Situation = new List<string>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Month2.buttonPressed == true)
        {
            if(Month2.carInsurancePaid == false)
            {
                string outcomes = "Not legally allowed to drive. May risk car being impounded if pulled overed";
                Situation.Add(outcomes);
            }

            if(Month2.internetPaid == false)
            {
                string outcomes = "You lose internet access for a month. You get very bored"; //Place Holder
                Situation.Add(outcomes);
            }

            if (Month2.Utilites == false)
            {
                string outcomes = "Your power, gas, and water are shut off. Resulting in higher food costs due to increase take outs."; //Place Holder
                Situation.Add(outcomes);
            }

            if (Month2.foodPaid == false)
            {
                string outcomes = "You have nothing to eat and must rely on hand outs and the Food Bank. You feel embarrassed."; //Place Holder
                Situation.Add(outcomes);
            }

            if (Month2.gaspaid == false)
            {
                string outcomes = "Your unable to drive your car for the month. You lose 1/2 your hours due to lack of transportation."; //Place Holder
                Situation.Add(outcomes);
            }

            if (Month2.rentPaid == false)
            {
                string outcomes = "You get a eviction letter from your landlord telling you to pay by next month or get out. You are extremely stressed out."; //Place Holder
                Situation.Add(outcomes);
            }

            


            Month2.buttonPressed = false;
        }
        AllSitucation = Situation.ToArray();
        Debug.Log(AllSitucation);
    }
}
