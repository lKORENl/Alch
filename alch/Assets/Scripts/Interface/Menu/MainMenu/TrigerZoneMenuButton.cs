﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrigerZoneMenuButton : MonoBehaviour
{
    public static int currentButton = 0;

    public void Start()
    {
        float p = Screen.width / 3;
        this.transform.GetChild(2).transform.position = new Vector2(this.transform.GetChild(3).position.x - p, this.transform.GetChild(0).position.y);
        this.transform.GetChild(1).transform.position = new Vector2(this.transform.GetChild(2).position.x - p, this.transform.GetChild(0).position.y);
        this.transform.GetChild(0).transform.position = new Vector2(this.transform.GetChild(1).position.x - p, this.transform.GetChild(0).position.y);


        this.transform.GetChild(4).transform.position = new Vector2(this.transform.GetChild(3).position.x + p, this.transform.GetChild(0).position.y);
        this.transform.GetChild(5).transform.position = new Vector2(this.transform.GetChild(4).position.x + p, this.transform.GetChild(0).position.y);

    }
    //при входе элемента в тригер зону
    private void OnTriggerEnter2D(Collider2D collision)
    {

        //проверяем есть ли у этого элемента скрипт MenuButton
        if (collision.transform.GetComponent<MenuButton>())
        {
            //переменная растояния между кнопками меню
            float p = Screen.width / 3;


            //увеличение скейла кнопки
            collision.transform.localScale = new Vector2(1.5f, 1.5f);
         
            //в зависимости какая кнопка зашла в тригер перемещаем крайние на нужные позиции
            switch (collision.name)
            {
                case "1":
                    currentButton = 1;
                    this.transform.GetChild(2).transform.position = new Vector2(this.transform.GetChild(1).position.x + p, this.transform.GetChild(0).position.y);
                    this.transform.GetChild(3).transform.position = new Vector2(this.transform.GetChild(4).position.x - p, this.transform.GetChild(0).position.y);
                    break;
                case "2":
                    currentButton = 2;
                    this.transform.GetChild(4).transform.position = new Vector2(this.transform.GetChild(5).position.x - p, this.transform.GetChild(0).position.y);
                    this.transform.GetChild(3).transform.position = new Vector2(this.transform.GetChild(2).position.x + p, this.transform.GetChild(0).position.y);
                    break;
                case "3":
                    currentButton = 3;
                    this.transform.GetChild(5).transform.position = new Vector2(this.transform.GetChild(0).position.x - p, this.transform.GetChild(0).position.y);
                    this.transform.GetChild(4).transform.position = new Vector2(this.transform.GetChild(3).position.x + p, this.transform.GetChild(0).position.y);
                    break;
                case "4":
                    currentButton = 4;
                    this.transform.GetChild(0).transform.position = new Vector2(this.transform.GetChild(1).position.x - p, this.transform.GetChild(0).position.y);
                    this.transform.GetChild(5).transform.position = new Vector2(this.transform.GetChild(4).position.x + p, this.transform.GetChild(0).position.y);
                    break;
                case "5":
                    currentButton = 5;
                    this.transform.GetChild(0).transform.position = new Vector2(this.transform.GetChild(5).position.x + p, this.transform.GetChild(0).position.y);
                    this.transform.GetChild(1).transform.position = new Vector2(this.transform.GetChild(2).position.x - p, this.transform.GetChild(0).position.y);              
                    break;
                case "6":
                    this.transform.GetChild(1).transform.position = new Vector2(this.transform.GetChild(0).position.x + p, this.transform.GetChild(0).position.y);
                    this.transform.GetChild(2).transform.position = new Vector2(this.transform.GetChild(3).position.x - p, this.transform.GetChild(0).position.y);
                    currentButton = 6;
                    break;
            }


            //уменяшаем количество перемещений в скроллере
            MenuScroller.reiteration--;



        }      
    }

    //при выходе из тригера
    private void OnTriggerExit2D(Collider2D collision)
    {
        //проверяем есть ли у этого элемента скрипт MenuButton
        if (collision.transform.GetComponent<MenuButton>())
        {
            currentButton = 0;
            //возвращаем скейл в нормальное положение
            collision.transform.localScale = new Vector2(1, 1);

        }
    }
}
