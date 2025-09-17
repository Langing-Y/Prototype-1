using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    //文本
    public TextMeshProUGUI scoreText;
    //每只动物分数
    public int score = 10;
    //当前分数
    private int currentScore = 0;

    //单例模式
    public static ScoreManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UpdateScoreUI();
    }

    public void AddScore(int animalScore)
    {
        score = animalScore;
        currentScore += score;
        UpdateScoreUI();
    }

    void UpdateScoreUI()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + currentScore;
        }
    }
}
