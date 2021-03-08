using UnityEngine;
public class EvilDice2 : Dice
{
    private int rollResult = 1;
    public void Pair()
    {
        Debug.Log("Yo soy el par de la familia");
    }

    private void reRoll()
    {
        while (rollResult%2 != 0)
        {
            rollResult = Random.Range(1, 11);
        }
        Debug.Log("yo siempre sere mejor que inpar >:3");
    }

    public int ReRoll
    {
        get { return rollResult;  }
        set
        {
            if (value == 2 || value == 4 || value == 6 || value == 8 || value == 10)
            {
                rollResult = value;
            }
        }
    }


}