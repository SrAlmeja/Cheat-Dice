using UnityEngine;
public class EvilDice1 : Dice
{
    private int rollResult = 1;
    public void UnPair()
    {
        Debug.Log("Yo soy el impar de la familia");
    }

    private void reRoll()
    {
        while (rollResult%2 != 0)
        {
            rollResult = Random.Range(1, 11);
        }
        Debug.Log("yo siempre sere el #1 °U°");
    }
    public int ReRoll
    {
        get { return rollResult; }
        set
        {
            if (value == 1 || value == 3 || value == 5 || value == 7 || value == 9)
            {
                rollResult = value;
            }
        }
    }


}
