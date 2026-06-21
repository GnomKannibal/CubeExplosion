using UnityEngine;

public class Explosioner : MonoBehaviour
{
    private float _explosionForce = 50f;
    private float _explosionRadius = 15f;
    private float _cubeSize;

    private Rigidbody _rigidbody;

    public void Explode(Cube explodingCube)
    {
        Rigidbody rigidityExplodingCube = explodingCube.Rigidbody;

        Collider[] hitColliders = Physics.OverlapSphere(explodingCube.transform.position, _explosionRadius);

        _cubeSize = explodingCube.transform.localScale.x;
        _explosionForce /= _cubeSize;
        _explosionRadius /= _cubeSize;

        for (int i = 0; i < hitColliders.Length; i++)
        {
            if (hitColliders[i].TryGetComponent<Cube>(out Cube cube))
            {
                Rigidbody rigibodyCube = cube.Rigidbody;

                rigibodyCube.AddExplosionForce(_explosionForce, explodingCube.transform.position, _explosionRadius);
            }
        }
    }
}
