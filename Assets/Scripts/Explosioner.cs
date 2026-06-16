using UnityEngine;

public class Explosioner : MonoBehaviour
{
    private int _explosionForce = 250;
    private int _explosionRadius = 5;

    private Rigidbody _rigidbody;

    public void Explode(Cube cube) 
    {
        _rigidbody = cube.GetComponent<Rigidbody>();

        _rigidbody.AddExplosionForce(_explosionForce, cube.transform.position, _explosionRadius);
    }
}
