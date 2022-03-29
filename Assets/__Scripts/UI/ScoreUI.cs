using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreUI : MonoBehaviour
{
    [SerializeField] Image scoreImage;

    // Start is called before the first frame update
    void Start()
    {
        Score.instance.UpdateScore.AddListener(UpdateScoreUI);
        UpdateScoreUI(0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void UpdateScoreUI(float score)
    {
        float temp = Mathf.Clamp(score / Score.instance.maxScore, 0, 1);
        scoreImage.fillAmount = temp;
    }
}
