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
        if (cube.isSplit())
        {
            _cubeSpawner.Spawn(cube);
            _explosioner.Explode(cube);
        }
        else 
        {
            _cubeSpawner.DeleteObject(cube);
        }
    }
}
