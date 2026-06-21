using UnityEngine;
using System.Collections.Generic;

public class CubeSplitter : MonoBehaviour
{
    [SerializeField] private RayCaster _rayCaster;
    [SerializeField] private Explosioner _explosioner;
    [SerializeField] private CubeSpawner _cubeSpawner;

    private List<Cube> _createdCubes = new List<Cube>();

    private void OnEnable()
    {
        _rayCaster.CubeDetected += Split;
    }

    private void OnDisable()
    {
        _rayCaster.CubeDetected -= Split;       
    }

    private void Split(Cube cube) 
    {
        if (cube.IsDivide())
        {
            _createdCubes = _cubeSpawner.Spawn(cube);

            _explosioner.Explode(cube, _createdCubes);

            _cubeSpawner.DeleteCube(cube);
        }
        else 
        {
            _cubeSpawner.DeleteCube(cube);
        }
    }
}
