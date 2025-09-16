using UnityEngine;

public class PlayerController2 : MonoBehaviour
{

    //玩家速度
    [Header("玩家速度")]
    public float playerSpeed = 5.0f;

    //左右限制值
    [Header("限制值")]
    public float limitNum = 60.0f;
    public float limitTop = 15.0f;
    public float limitDown = 1.0f;

    [Header("披萨预制体")]
    public GameObject projectilePrefab;

    //缓存变量，使用set进行修改，防止重复生成
    private Vector3 currentSpot;
    private Vector3 moveVector;


    // Update is called once per frame
    void Update()
    {
        HandleMovement();
        HandleShooting();
    }

    //处理移动
    void HandleMovement()
    {
        //限制玩家移动距离
        currentSpot = transform.position;

        //Mathf.Clamp限制一个值在最大和最小范围内；
        currentSpot.x = Mathf.Clamp(currentSpot.x, -limitNum, limitNum);
        currentSpot.z = Mathf.Clamp(currentSpot.z, limitDown, limitTop);
        transform.position = currentSpot;

        //实现移动
        moveVector.Set(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        transform.Translate(moveVector * Time.deltaTime * playerSpeed);
    }

    //处理射击
    void HandleShooting()
    {
        //释放食物逻辑
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //从玩家处发射食物
            Debug.Log("press Space");
            // 添加这个检查
            if (projectilePrefab == null)
            {
                Debug.LogError("projectilePrefab is null! Please assign it in the Inspector.");
                return;
            }

            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
            Debug.Log("Pizza instantiated!");
        }
    }
}
