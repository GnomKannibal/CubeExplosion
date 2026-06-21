using System;
using UnityEngine;

public class RayCaster : MonoBehaviour
{
    [SerializeField] private InputReader _inputReader;
    private Camera _cam;
    private Ray _ray;

    public event Action<Cube> CubeDetected;

    private void OnEnable()
    {
        _inputReader.ButtonClicked += FindPointClick;
    }

    private void OnDisable()
    {
        _inputReader.ButtonClicked -= FindPointClick;
    }

    private void Start()
    {
        _cam = Camera.main;
    }

    private void FindPointClick()
    {
        _ray = _cam.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(_ray.origin, _ray.direction, out RaycastHit hit, Mathf.Infinity))
        {
            if (hit.collider.TryGetComponent<Cube>(out Cube cube))
                CubeDetected?.Invoke(cube);
        }
    }
}
