using Unity.Mathematics;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    
    void Start()
    {
        InvokeRepeating("SpawnEnemy", 2f, 3f);
    }

    void SpawnEnemy()
    {
        float rangeX = UnityEngine.Random.Range(-10f, 10f);
        Vector3 toaDo = new Vector3(rangeX, 6f, 0f);
        Instantiate(enemyPrefab, toaDo, quaternion.identity);
    }
}
