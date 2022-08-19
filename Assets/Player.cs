using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{

    public static int health;



    public int power;
    public string name;

    public Player()
    {
        power = 100;
        health = 100;
        name = "Warrior";
    }

    public static void printSomething()
    {

    }
    
    
    
    
    public void SetPower(int power)
    {
        this.power = power;
    }

    public int GetPower()
    {
        return this.power;
    }




} // Player
