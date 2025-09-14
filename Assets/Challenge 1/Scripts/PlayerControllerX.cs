using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    [Header("方向翻转")]
    public bool isSwap = true;

    public float speed;
    public float rotationSpeed;
    public float verticalInput;

    private float swap = 1;

    // Start is called before the first frame update
    void Start()
    {
        //判断翻转
        if (isSwap)
        {
            swap = -swap;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime * verticalInput * swap);
    }
}
