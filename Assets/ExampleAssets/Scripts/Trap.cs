using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Threading;



public class Trap: MonoBehaviour {
    private System.Random rnd = new System.Random();
    private int fullAmount = 4;
    private bool isActive = false;
    private int lobsters = 0;
    private int interval = 30 * 1000; //This is milliseconds, this is why it is multiplied by 1000
    
    public bool full = false;

    public void Start()
    {
        
    }

    public void Update()
    {
        
    }


    

    

    public void Commence()
    {
        this.isActive = true; //sets is active to true
        while (this.isActive == true) //starts a loop to randomize the amount of lobsters we get over time.
        {
            Thread.Sleep(this.interval); //A problem might occure when trying to add sleeping to the game.
            double rng = rnd.NextDouble();

            if(lobsters == this.fullAmount)
            {
                full = true;
            }
            if (rng > 0.5 && full == false)
            {
                this.Increment();
            }
        }
    }


    private void Increment() //used to increment the amount of lobsters
    {
        this.lobsters += 1;
    }

    public int ReturnLobster()
    {
        this.isActive = false;
        return this.lobsters;
    }
}
