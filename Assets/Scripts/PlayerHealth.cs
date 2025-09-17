using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    //玩家生命值
    public static int health = 3;
    //当前类的实例，方便调用
    public static PlayerHealth Instance;


    private void Awake()
    {
        //确保只有一个生命管理器
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    //受伤函数
    public static void TakeDamage()
    {
        health -= 1;
        Debug.Log("受到伤害！当前生命值：" + health);

        if (health <= 0)
        {
            Debug.Log("Game Over");
        }
    }

}
