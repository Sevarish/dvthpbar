using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Damage : MonoBehaviour {
    public int health;
    public Text healthBar;

    private void Start()
    {
        health = 67;

    }


    public void decreaseHealth()
    {
        health--;
        print("Mew");
        switch (health)
        {
            case 67:
                healthBar.text = "HP: lllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllll";
                break;
            case 64:
                healthBar.text = "HP: llllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllll";
                break;
            case 61:
                healthBar.text = "HP: llllllllllllllllllllllllllllllllllllllllllllllllllllllllllllll";
                break;
            case 58:
                healthBar.text = "HP: lllllllllllllllllllllllllllllllllllllllllllllllllllllllllll";
                break;
            case 55:
                healthBar.text = "HP: llllllllllllllllllllllllllllllllllllllllllllllllllllllll";
                break;
            case 52:
                healthBar.text = "HP: lllllllllllllllllllllllllllllllllllllllllllllllllllll";
                break;
            case 49:
                healthBar.text = "HP: llllllllllllllllllllllllllllllllllllllllllllllllll";
                break;
            case 46:
                healthBar.text = "HP: lllllllllllllllllllllllllllllllllllllllllllllll";
                break;
            case 43:
                healthBar.text = "HP: llllllllllllllllllllllllllllllllllllllllllll";
                break;
            case 40:
                healthBar.text = "HP: lllllllllllllllllllllllllllllllllllllllll";
                break;
            case 37:
                healthBar.text = "HP: llllllllllllllllllllllllllllllllllllll";
                break;
            case 34:
                healthBar.text = "HP: lllllllllllllllllllllllllllllllllll";
                break;
            case 31:
                healthBar.text = "HP: llllllllllllllllllllllllllllllll";
                break;
            case 28:
                healthBar.text = "HP: lllllllllllllllllllllllllllll";
                break;
            case 25:
                healthBar.text = "HP: llllllllllllllllllllllllll";
                break;
            case 22:
                healthBar.text = "HP: lllllllllllllllllllllll";
                break;
            case 19:
                healthBar.text = "HP: llllllllllllllllllll";
                break;
            case 16:
                healthBar.text = "HP: lllllllllllllllll";
                break;
            case 13:
                healthBar.text = "HP: llllllllllllll";
                break;
            case 10:
                healthBar.text = "HP: lllllllllll";
                break;
            case 7:
                healthBar.text = "HP: lllllll";
                break;
            case 4:
                healthBar.text = "HP: lllll";
                break;
            case 1:
                healthBar.text = "HP: l";
                break;
            case 0:
                healthBar.text = "HP: Nulle";
                break;



        }
    }


}
