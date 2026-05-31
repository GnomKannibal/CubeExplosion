using UnityEngine;

public class CubeSplitter : MonoBehaviour
{
    [SerializeField] private Cube _cubePrefab;

    private void SpawnCubes()
    {
        const int ChanceMaxNumber = 100;
        const int ChanceReducerNumber = 2;
        const int ExplosionForceNumber = 250;
        const int ExplosionRadiusNumber = 5;

        System.Random random = new System.Random();

        Rigidbody rigidbody = gameObject.GetComponent<Rigidbody>();

        Renderer renderer;

        int spawnCountMin = 2;
        int spawnCountMax = 6;

        if (random.Next(ChanceMaxNumber + 1) <= _cubePrefab.GetChance())
        {
            Debug.Log(_cubePrefab.GetChance());

            for (int i = 0; i < random.Next(spawnCountMin, spawnCountMax); i++)
            {
                Cube newCube = Instantiate(_cubePrefab);

                newCube.Initialize(_cubePrefab.GetChance() / ChanceReducerNumber);

                newCube.transform.localScale /= 2;

                renderer = newCube.GetComponent<Renderer>();

                renderer.material.color = UnityEngine.Random.ColorHSV();
            }

            rigidbody.AddExplosionForce(ExplosionForceNumber, gameObject.transform.position, ExplosionRadiusNumber);
        }

        GameObject.Destroy(gameObject);
    }

    private void OnMouseDown()
    {
        SpawnCubes();
    }
}
