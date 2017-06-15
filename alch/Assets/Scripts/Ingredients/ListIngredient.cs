﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListIngredient : MonoBehaviour {

    int id;

    List<Ingredient> ingredients;

	// Use this for initialization
	void Start () {
        ingredients = new List<Ingredient>() {
            new Ingredient(0,"salt","salt",5,10,15),
            new Ingredient(1, "lavanda", "lavanda",10,10,10),
            new Ingredient(2, "gold","gold",20,15,10),
            new Ingredient(3, "korn","korn",20,20,20),
            new Ingredient(4, "silver", "siver",25,20,30)
        };
       // Debug.Log("Ingredients done!");
	}

    public Ingredient GetIngredietnById(int x)
    {     
        return ingredients.Find(i => i.Id == x);
    }
	

}
