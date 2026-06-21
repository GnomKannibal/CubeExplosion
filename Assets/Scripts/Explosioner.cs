using UnityEngine;
using System.Collections.Generic;

public class Explosioner : MonoBehaviour
{
    private int _explosionForce = 250;
    private int _explosionRadius = 5;

    private Rigidbody _rigidbody;

    private List<Cube> _createdCubes = new List<Cube>();

    public void Explode(Cube explodingCube, List<Cube> createdCubes) 
    {
        Rigidbody rigidityExplodingCube = explodingCube.RigidbodyComponent;

        for (int i = 0; i < createdCubes.Count; i++) 
        {
            Rigidbody rigibodyCreatedCube = createdCubes[i].RigidbodyComponent;

            rigibodyCreatedCube.AddExplosionForce(_explosionForce, explodingCube.transform.position, _explosionRadius);
        }        
    }
}
