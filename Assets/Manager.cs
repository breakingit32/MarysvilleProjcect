using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour 
{
    public static Manager M;
    public Month2 month2;
    public Player[] players;
    public int playerTracker = 0;
    public string[] scenes = { "Player 1", "Player 2", "Player 3", "Player 4", "Player 5" };
    // Start is called before the first frame update
    void Start()
    {
        
        

        

        players[0].SetBools();
        players[1].SetBools();
        players[2].SetBools();
        players[3].SetBools();
        players[4].SetBools();

        month2.SetVar();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerTracker == 5) playerTracker = 0;
    }
}
