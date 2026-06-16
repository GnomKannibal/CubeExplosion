using Unity.VisualScripting;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    public void Spawn(Cube cube)
    {
        const int ChanceReducerNumber = 2;

        Renderer renderer;
        int spawnCountMin = 2;
        int spawnCountMax = 6;

        int spawnCubesCount = Random.RandomRange(spawnCountMin, spawnCountMax);

        for (int i = 0; i < spawnCubesCount; i++)
        {
            Cube newCube = Instantiate(cube);

            newCube.Initialize(cube.GetChance() / ChanceReducerNumber);

            newCube.transform.localScale /= 2;

            renderer = newCube.GetComponent<Renderer>();

            renderer.material.color = UnityEngine.Random.ColorHSV();
        }

        DeleteObject(cube);
    }

    public void DeleteObject(Cube cube) 
    {
        GameObject.Destroy(cube.gameObject);
    }
}
