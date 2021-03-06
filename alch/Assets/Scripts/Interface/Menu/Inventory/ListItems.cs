﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListItems : MonoBehaviour {

   public static LisItemInInventory itemList;


    public  void LoadFromDB()
    {
        if (PlayerPrefs.HasKey("itemList"))
        {
            itemList = null;
            itemList = SerializerDeserializer.Deserialize<LisItemInInventory>(PlayerPrefs.GetString("itemList"));
        }
        else
        {
            itemList = new LisItemInInventory();
            itemList.list = itemList.StartInventory();
            SaveInDB();
        }
    }



    public  void SaveInDB()
    {    
        PlayerPrefs.SetString("itemList", SerializerDeserializer.Serialize<LisItemInInventory>(itemList));
    }

    public LisItemInInventory GetListItemInInventory()
    {
        return itemList;
    }

    public void AddItem(int id , string type)
    {
        ItemInInventory it = itemList.AddItemInInventory(id, type);

        Debug.Log("after create " + it.count);
        if (!it.stackabl)
        {
            itemList.list.Add(it);
            Inventory.changList = true;
        }
        else
        {
            // Debug.Log("stakabl ");
            if (itemList.CheckItemInInventory(it))
            {
                // Debug.Log("есть в инвентаре  ");
                bool flag = true;
                foreach (var item in itemList.list)
                {
                    if (item.id == it.id && item.type == it.type && item.count < 99)
                    {
                        // Debug.Log("есть не заполненный стак  ");
                        item.count++;
                        Inventory.changList = true;
                        flag = false;
                        break;
                    }
                }
                if (flag)
                {
                    // Debug.Log("нет не заполненных стаков  ");
                    itemList.list.Add(it);
                    Inventory.changList = true;
                }
            }
            else
            {
                // Debug.Log("нет в инвентаре  ");
                itemList.list.Add(it);
                Inventory.changList = true;
            }
        }

        Debug.Log("after search " + it.count);
        SaveInDB();
    }




    public  void DeleteAllValue()
    {
        PlayerPrefs.DeleteAll();
    }


}
