using System;
using UnityEngine;

public class DestoryOutOfBonus : MonoBehaviour
{
    private float topBound = 30.0f;
    private float lowerBound = -10.0f;
    private float sideBound = 30.0f;


    // Update is called once per frame
    void Update()
    {
        DestoryBonus();
    }

    void DestoryBonus()
    {
        //如果物体超过边界则销毁
        if (transform.position.z > topBound || transform.position.z < lowerBound || Mathf.Abs(transform.position.x) > sideBound)
        {
            //Debug.Log("outside");
            Destroy(gameObject);
        }
    }
}
