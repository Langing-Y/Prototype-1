using UnityEngine;

public class PlayerController2 : MonoBehaviour
{
    //获取水平输入
    [Header("水平输入")]
    public float horizontalInput;
    //玩家速度
    [Header("玩家速度")]
    public float playerSpeed = 5.0f;
    //左右限制值
    [Header("左右限制值")]
    public float limitNum = 60.0f;

    [Header("披萨预制体")]
    public GameObject projectilePrefab;

    private float playerSpot;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //移动逻辑
        horizontalInput = Input.GetAxis("Horizontal");
        //限制玩家移动距离
        playerSpot = transform.position.x;
        if (Mathf.Abs(playerSpot) > limitNum)
            transform.position = playerSpot < 0 ? new Vector3(-limitNum, 0, 0) : new Vector3(limitNum, 0, 0);
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * playerSpeed);

        //释放食物逻辑
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //从玩家处发射食物
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
