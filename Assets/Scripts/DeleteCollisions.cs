using Unity.VisualScripting;
using UnityEngine;

public class DeleteCollisions : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("IsPlayer");
            Debug.Log("Game Over");
        }
        else if(other.CompareTag("Food"))
        {
            Debug.Log("eat food");
            Destroy(gameObject);
            Destroy(other.gameObject);
        }

    }
}
