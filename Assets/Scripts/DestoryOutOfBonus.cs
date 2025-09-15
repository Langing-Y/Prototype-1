using UnityEngine;

public class DestoryOutOfBonus : MonoBehaviour
{
    private float topBound = 30.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Mathf.Abs(transform.position.z) > topBound)
        {
            Destroy(gameObject);
        }
    }
}
