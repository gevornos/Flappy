using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance {get; set;}
    [SerializeField] private TextMeshProUGUI scoreText;
    private int score;


    private void Start()
    {
        Instance = this;
        SetScore(0);
    }

    public void SetScore(int score)
    {
        this.score += score;
        scoreText.text = "Score: " + this.score.ToString();
    }

}
