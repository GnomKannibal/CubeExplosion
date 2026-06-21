using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    public List<Cube> Spawn(Cube cube)
    {
        const int ChanceDivider = 2;
        const int ScaleDivider = 2;

        int spawnCountMin = 2;
        int spawnCountMax = 6;

        int spawnCubesCount = Random.Range(spawnCountMin, spawnCountMax);

        Renderer renderer;
        List <Cube> createdCubes = new List <Cube>();

        for (int i = 0; i < spawnCubesCount; i++)
        {
            Cube newCube = Instantiate(cube);

            newCube.InitializeChance(cube.SplitChance / ChanceDivider);
            newCube.transform.localScale /= ScaleDivider;

            renderer = newCube.RendererComponent;
            renderer.material.color = Random.ColorHSV();

            createdCubes.Add(newCube);
        }

        return createdCubes.ToList();
    }

    public void DeleteCube(Cube cube) 
    {
        GameObject.Destroy(cube.gameObject);
    }
}
