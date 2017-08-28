﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecipesSelector : MonoBehaviour
{
    

    public void GetResipeId()
    {

        int id = System.Convert.ToInt32(this.gameObject.transform.name);

        foreach (Recipe r in ListRecipes.recipes)
        {
            if (r.Id == id)
            {             
                CookingProcess.recipe = new Recipe(r.Id,r.idPotion,r.Hard ,r.spritePas, r.MassIngr);
                CookingProcess.recipeHard = r.Hard;
               // CookingProcess.currentRecipeIngr = r.MassIngr[0];
                CookingProcess.firstStady = true;
                break;
            };
        }

    }
}
