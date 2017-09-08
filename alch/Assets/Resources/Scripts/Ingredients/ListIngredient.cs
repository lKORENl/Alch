﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListIngredient : MonoBehaviour {

    int id;

    public static List<Ingredient> ingredients;

	// Use this for initialization
	void Start () {
        ingredients = new List<Ingredient>() {
            new Ingredient(0,"heat","Images/Ingr/0"),
            new Ingredient(1, "mix", "Images/Ingr/1"),
            new Ingredient(2, "gold","Images/Ingr/gold"),
            new Ingredient(3, "root","Images/Ingr/root"),
            new Ingredient(4, "silver", "Images/Ingr/silver"),
            new Ingredient(5, "salt","Images/Ingr/salt"),
            new Ingredient(6, "lavanda","Images/Ingr/lavanda"),
        };
       // Debug.Log("Ingredients done!");
	}

    public Ingredient GetIngredietnById(int x)
    {     
        return ingredients.Find(i => i.Id == x);
    }
    public static string GetSpritePassById(int x)
    {
        return  ingredients[x].SpritePass;
    }

}
