using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{
    private static Character instance;
    private int score;
    private string saveDataFile;
    private List enemies;

    public List Eneies
    {
        get { return enemies; }
    }
    public static Character Singleton
    {
        //creating the single instance of the class
        //if already exists then return that instance
        get
        {
            if (instance == null)
            {
                instance = new Character();
            }
            return instance;
        }
    }
    public void AddEnemy(Enemy e)
    {
        .......; //add enemy logic
    }
    public void RemoveEnemy(Enemy e)
    {
        ......; //remove enemy logic
    }
    /*
    //variables
    int health;
    List inventory;
    int level;
    string saveDataFile;
    int i;
    Mesh characterModel;
    List enemies;

    //Methods
    void character()
    {
        string name = "Xyz";
        health = 100;
        inventory = new List();

    }

    void SetHealth(int h)
    {
        health = h;
    }
    void PrintInventory()
    {
        for (int i = 0; i < inventory.Count; i++)
        {
            Print(inventory[i]);
        }
    }
    int GetHealth()
    {
        return health;
    }
    */
}
