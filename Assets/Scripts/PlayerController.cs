using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("车辆参数")]
    public float VehicleSpeed = 10.0f;
    public float turnSpeed = 50.0f;

    [Header("真实转向设置")]
    [Range(0f, 1f)]
    public float minSpeedForTurn = 0.1f;  // 最小转向速度阈值

    private float verticalInput;
    private float horizontalInput;
    private float currentSpeed;  // 当前实际速度

    void Start()
    {

    }

    void Update()
    {
        // 获取输入
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        // 计算当前速度（考虑方向）
        currentSpeed = verticalInput * VehicleSpeed;

        // 移动车辆
        //transform.Translate(1,0,0);
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * VehicleSpeed);

        // 真实转向逻辑：只有在移动时才能转向
        if (Mathf.Abs(currentSpeed) > minSpeedForTurn)
        {
            // 转向幅度与速度成正比，倒车时转向相反
            float turnAmount = horizontalInput * turnSpeed * Time.deltaTime;

            // 倒车时转向方向相反
            if (verticalInput < 0)
            {
                turnAmount = -turnAmount;
            }

            transform.Rotate(Vector3.up * turnAmount);
        }
    }
}