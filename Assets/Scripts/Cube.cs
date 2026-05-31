using UnityEngine;

public class Cube : MonoBehaviour
{
    private int _splitChance = 100;

    public int GetChance() 
    {
        return _splitChance;
    }

    public void Initialize(int chance)
    {
        _splitChance = chance;
    }
}
