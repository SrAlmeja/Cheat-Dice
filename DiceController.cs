using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceController : MonoBehaviour
{
    Dice woodDice = new Dice(4, 4, "green", "wood");
    Dice redDice = new Dice(6, 8, "red", "plastic");
    Dice sixFaceDice = new Dice(6, 8, "blue", "plastic");
    Dice dice1 = new Dice();
    //Dice dice6 = new Dice(6);

    EvilDice1 crookedDice = new EvilDice1();
    EvilDice2 crookedDice2 = new EvilDice2();

    //Dice numberOfDices = new Dice();



    // Start is called before the first frame update
    void Start()
    {

        Debug.Log("Color dado madera: " + woodDice.Color);
        woodDice.Color = "red";
        Debug.Log("Color dado madera: " + woodDice.Color);
        Debug.Log("Hay un total de " + Dice.countDice + " dados");

        crookedDice.UnPair();
        crookedDice2.Pair();
        //numberOfDices.countDice();




    }

    // Update is called once per frame
    void Update()
    {


    }
}