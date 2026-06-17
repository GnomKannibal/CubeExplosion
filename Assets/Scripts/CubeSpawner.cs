using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    public void Spawn(Cube cube, int spawnCubesCount)
    {
        const int DividerInHalf = 2;

        Renderer renderer;

        for (int i = 0; i < spawnCubesCount; i++)
        {
            Cube newCube = Instantiate(cube);

            newCube.InitializeChance(cube.SplitChance / DividerInHalf);

            newCube.transform.localScale /= DividerInHalf;

            renderer = newCube.GetComponent<Renderer>();

            renderer.material.color = Random.ColorHSV();
        }

        GameObject.Destroy(cube.gameObject);
    }
}
