using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject enemyPrefab;
    private float spawnRange = 9;
    public bool funMode = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (!funMode)
         {
            Instantiate(enemyPrefab, GenerateSpawnPosition(), enemyPrefab.transform.rotation);
        }
    }

    private Vector3 GenerateSpawnPosition ()
    {
        float spawnPosX = Random.Range(-spawnRange, spawnRange);
        float spawnPosZ = Random.Range(-spawnRange, spawnRange);
        Vector3 randomPos = new Vector3(spawnPosX, 15, spawnPosZ);
        return randomPos;
    }

    // Update is called once per frame
    void Update()
    {
        if (funMode)
        {
            Instantiate(enemyPrefab, new Vector3(0, 0, 0), enemyPrefab.transform.rotation);
        }
    }
}
