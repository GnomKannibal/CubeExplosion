using UnityEngine;

[RequireComponent(typeof(Renderer), typeof(Rigidbody))]
public class Cube : MonoBehaviour
{
    public int SplitChance { get; private set; } = 100;
    public Renderer RendererComponent { get; private set; }
    public Rigidbody RigidbodyComponent { get; private set; }

    private void Awake()
    {
        RendererComponent = GetComponent<Renderer>();
        RigidbodyComponent = GetComponent<Rigidbody>();
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
