using UnityEngine;

public class CubeSplitter : MonoBehaviour
{
    [SerializeField] private RayCaster _rayCaster;
    [SerializeField] private Explosioner _explosioner;
    [SerializeField] private CubeSpawner _cubeSpawner;

    private void OnEnable()
    {
        _rayCaster.CubeClicked += Split;
    }

    private void OnDisable()
    {
        _rayCaster.CubeClicked -= Split;       
    }

    private void Split(Cube cube) 
    {
        int spawnCountMin = 2;
        int spawnCountMax = 6;

        int spawnCubesCount = Random.Range(spawnCountMin, spawnCountMax);

        if (cube.IsDivide())
        {
            _cubeSpawner.Spawn(cube, spawnCubesCount);

            _explosioner.Explode(cube);
        }
        else 
        {
            spawnCubesCount = 0;

            _cubeSpawner.Spawn(cube, spawnCubesCount);
        }
    }
}
