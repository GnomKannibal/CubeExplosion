using UnityEngine;

public class CubeSplitter : MonoBehaviour
{
    [SerializeField] private RayCaster _rayCaster;
    [SerializeField] private Explosioner _explosioner;
    [SerializeField] private CubeSpawner _cubeSpawner;

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
        if (cube.CanDivide())
        {
            _cubeSpawner.Spawn(cube);

            _explosioner.Explode(cube);
        }

        _cubeSpawner.DeleteCube(cube);
    }
}
