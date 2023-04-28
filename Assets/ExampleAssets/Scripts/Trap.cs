using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Threading;



public class Trap {
    private System.Random rnd = new System.Random();
    private bool isActive { get; set; }
    private int lobsters { get; set; }
    private int interval = 30 * 1000; //This is milliseconds, this is why it is multiplied by 1000
    private double increment { get; set; }
    public bool full = false;

    public Trap (double Increment) { //initialises the Trap at zero lobsters and not active.
        this.isActive = false;
        this.lobsters = 0;
        
    }

    public void Start()
    {
        this.isActive = true; //sets is active to true
        while (this.isActive == true) //starts a loop to randomize the amount of lobsters we get over time.
        {
            Thread.Sleep(this.interval);
            double rng = rnd.NextDouble();
            if (rng > 0.5)
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
