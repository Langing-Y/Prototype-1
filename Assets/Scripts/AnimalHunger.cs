using UnityEngine;
using UnityEngine.UI;

public class AnimalHunger : MonoBehaviour
{
    public Slider hungerSlider;
    public int amountToBeFed;

    private int currentFedAmount = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //设置滑块最大值
        hungerSlider.maxValue = amountToBeFed;
        //设置滑块当前值
        hungerSlider.value = 0;
        //隐藏滑动条
        hungerSlider.fillRect.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    //喂动物时
    public void FeedAnimal(int amount)
    {
        currentFedAmount += amount;
        hungerSlider.fillRect.gameObject.SetActive(true);
        hungerSlider.value = currentFedAmount;
        //ScoreManager scoreManager=GetComponent<ScoreManager>();

        if (currentFedAmount >= amountToBeFed)
        {
            if(ScoreManager.instance != null)
            {
                ScoreManager.instance.AddScore(amountToBeFed * 10);
            }
            Destroy(gameObject, 0.1f);
        }
    }
}
