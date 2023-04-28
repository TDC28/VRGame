using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Threading;



public class Trap: MonoBehaviour {
    private System.Random rnd = new System.Random();
    private int fullAmount = 10;
    private bool isActive = false;
    private int lobsters = 0;
    private int interval = 30 * 1000; //This is milliseconds, this is why it is multiplied by 1000
    
    public bool full = false;

    public void Start()
    {
        //Highly advise getting the components(rigidbody, colliders and everything to be able to apply forces and etc.)
    }

    public void Update()
    {
        //Check if trap is in water, if yes call commence. If it is coming out of water, use ReturnLobster to return the amount of lobsters, it should automatically shut of Commence()
    }


    

    

    public void Commence() //Start this function when the it touches water
    {
        this.isActive = true; //sets is active to true
        while (this.isActive == true) //starts a loop to randomize the amount of lobsters we get over time.
        {
            Thread.Sleep(this.interval); //A problem might occure when trying to add sleeping to the game
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

    public int ReturnLobster() //Use this function when removing the trap from the water
    {
        this.isActive = false;
        return this.lobsters;
    }
}
