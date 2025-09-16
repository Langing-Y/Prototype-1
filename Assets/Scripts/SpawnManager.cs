using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //生成管理器
    public GameObject[] animalPrefabs;
    //生成坐标
    private float spawnRangeX = 20;
    private float spawnTop = 20;
    private float spawnBottom = -5;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //将字符串所含的函数在第二秒执行一次，之后每隔两秒再执行一次
        InvokeRepeating("SpawnRandomAnimal", 1, 2.0f);
    }

    //在上方生成动物
    void SpawnRandomAnimal()
    {
        //随机生成
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        int animalIndex1 = Random.Range(0, animalPrefabs.Length);
        int animalIndex2 = Random.Range(0, animalPrefabs.Length);

        //Debug.Log($"生成动物: 上方={animalIndex}, 左侧={animalIndex1}, 右侧={animalIndex2}");

        //随机位置
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnTop);
        Vector3 spawnPosLeft = new Vector3(-spawnRangeX, 0, Random.Range(spawnBottom, spawnTop));
        Vector3 spawnPosRight = new Vector3(spawnRangeX, 0, Random.Range(spawnBottom, spawnTop));

        //生成动物
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
        Instantiate(animalPrefabs[animalIndex1], spawnPosLeft, Quaternion.Euler(0, 90, 0));
        Instantiate(animalPrefabs[animalIndex2], spawnPosRight, Quaternion.Euler(0, -90, 0));
    }

}

