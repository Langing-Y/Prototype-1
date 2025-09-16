using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    [Header("Dog Spawning Settings")]
    public GameObject dogPrefab;
    public float spawnCooldown = 2.0f;

    [Header("Debug Info")]
    [SerializeField] private bool canSpawn = true;


    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && canSpawn)
        {
            SpawnDog();
        }
    }

    void SpawnDog()
    {
        // 生成狗
        Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);

        // 开始冷却协程
        StartCoroutine(SpawnCooldownCoroutine());
    }

    IEnumerator SpawnCooldownCoroutine()
    {
        canSpawn = false;
        
        // 等待冷却时间
        yield return new WaitForSeconds(spawnCooldown);

        canSpawn = true;
    }
}
