using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public GameObject optionalParent;
    public bool spawnInOrder;
    public GameObject[] spawnerThese;
    public int max;
    public float spawnPerSec;

    void Start()
    {
        Spawn();
        spawnTimer = spawnPerSec;
    }

    int spawnCount;
    int spawnSequence;

    void Spawn()
    {
        if (spawnInOrder)
        {
            ++spawnTimer;
            spawnSequence = (int)Mathf.Repeat(spawnSequence, spawnerThese.Length);
        }
        else       
            spawnSequence = Random.Range(0, spawnerThese.Length);

        GameObject object_to_spawn = spawnerThese[spawnSequence];
        Vector3 pos = transform.position;
        pos += Vector3.Scale(Random.insideUnitSphere, new Vector3(10.0f, 10.0f, 10.0f));
        GameObject new_obj = Instantiate(object_to_spawn, pos, Quaternion.identity);
        if (optionalParent)
            new_obj.transform.parent = optionalParent.transform;
        ++spawnCount;
    }

    float spawnTimer;

    void Update()
    {
        if (spawnCount >= max)
            return;

        spawnTimer -= Time.deltaTime;

        if (spawnTimer < 0.0f)
        {
            Spawn();
            spawnTimer = spawnPerSec;
        }
    }
}
