using UnityEngine;

public class Cube : MonoBehaviour
{
    public int SplitChance { get; private set; } = 100;

    public bool IsDivide() 
    {
        const int ChanceMaxNumber = 100;
        const int ChanceMinNumber = 0;

        int randomChanceProke = Random.Range(ChanceMinNumber, ChanceMaxNumber + 1);

        return randomChanceProke <= SplitChance;
    }

    public void InitializeChance(int chance)
    {
        SplitChance = chance;
    }
}
