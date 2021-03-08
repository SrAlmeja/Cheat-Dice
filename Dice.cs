using UnityEngine;

public class Dice
{

    // Atributes
    private int numberOfFaces;
    private int numberOfEdges;
    private string color;
    private string material;
    private float sizeX;
    private bool available = false;
    private float radius;
    static public int countDice = 10;

    // Constructors
    public Dice(int anumberOfFaces, int anumberOfEdges, string acolor, string amaterial)
    {
        numberOfFaces = anumberOfFaces;
        numberOfEdges = anumberOfEdges;
        color = acolor;
        material = amaterial;
        countDice++;
    }

    public Dice()
    {

    }

    public int NumberOfFaces
    {
        get { return numberOfFaces;  }
        set
        {
            if (value ==  10)
            {
                numberOfFaces = value;
            }
            else
            {
                numberOfFaces = 0;
                Debug.Log("Lo sentimos el dado que estas buscando no existe");
            }
        }
    }

    // Methods
    public void helloDice()
    {
        Debug.Log("Hola desde la clase dice");
    }


    // Getters Setters Properties
    public string Color
    {
        get { return color; }
        set
        {
            if (value == "green" | value == "red")
            {
                color = value;
            }
            else
            {
                color = "NA";
            }
        }
    }

    ////
    //public int CountDice
    //{
    //    get { return countDice; }
    //    set
    //    {
    //        if (value == 10)
    //        {
    //            countDice = value;
    //        }
    //        else
    //        {
    //            countDice = 0;
    //            Debug.Log("404 Error...");
    //        }
    //    }
    //}
    ////
}

