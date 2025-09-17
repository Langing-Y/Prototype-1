using Unity.VisualScripting;
using UnityEngine;

public class DeleteCollisions : MonoBehaviour
{
    public static int health = 3;

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
            //调用玩家受伤的方法
            PlayerHealth.TakeDamage();

            Destroy(gameObject);
        }
        else if (other.CompareTag("Food"))
        {
            Debug.Log("eat food");
            AnimalHunger animalHunger=GetComponent<AnimalHunger>();
            if (animalHunger != null)
            {
                animalHunger.FeedAnimal(1);
            }
            Destroy(other.gameObject);
        }

    }
}
