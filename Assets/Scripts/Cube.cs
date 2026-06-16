using UnityEngine;

public class Cube : MonoBehaviour
{
    private int _splitChance = 100;

    public bool isSplit() 
    {
        const int ChanceMaxNumber = 100;

        System.Random random = new System.Random();

        return random.Next(ChanceMaxNumber + 1) <= _splitChance;
    }

    public int GetChance() 
    {
        return _splitChance;
    }

    public void Initialize(int chance)
    {
        _splitChance = chance;
    }
}
