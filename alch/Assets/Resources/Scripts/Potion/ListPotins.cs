﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListPotins : MonoBehaviour {

    public static List<Potion> potions;
	// Use this for initialization
	void Start () {
        potions = new List<Potion>() {
            new Potion(0,"tea",5, "Images/Ingr/salt"),
            new Potion(1,"helth",10, "Images/Ingr/salt"),
            new Potion(2, "poison",15, "Images/Ingr/salt"),
            new Potion(4, "poison",20, "Images/Ingr/salt")
        };

       // Debug.Log("Potions done!");

    }
    public  Potion GetIngredietnById(int x)
    {
        return potions.Find(i => i.Id == x);
    }


}
