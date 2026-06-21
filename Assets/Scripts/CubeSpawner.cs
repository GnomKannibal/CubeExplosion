using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    public void Spawn(Cube cube)
    {
        const int ChanceDivider = 2;
        const int ScaleDivider = 2;

        int spawnCountMin = 2;
        int spawnCountMax = 6;

        int spawnCubesCount = Random.Range(spawnCountMin, spawnCountMax);

        Renderer renderer;

        for (int i = 0; i < spawnCubesCount; i++)
        {
            Cube newCube = Instantiate(cube);

            newCube.InitializeChance(cube.SplitChance / ChanceDivider);
            newCube.transform.localScale /= ScaleDivider;

            renderer = newCube.Renderer;
            renderer.material.color = Random.ColorHSV();
        }
    }

    public void DeleteCube(Cube cube) 
    {
        GameObject.Destroy(cube.gameObject);
    }
}
