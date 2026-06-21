using UnityEngine;

[RequireComponent(typeof(Renderer), typeof(Rigidbody))]
public class Cube : MonoBehaviour
{
    public int SplitChance { get; private set; } = 100;
    public Renderer Renderer { get; private set; }
    public Rigidbody Rigidbody { get; private set; }

    private void Awake()
    {
        Renderer = GetComponent<Renderer>();
        Rigidbody = GetComponent<Rigidbody>();
    }

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
