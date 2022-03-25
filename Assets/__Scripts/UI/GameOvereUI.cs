using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOvereUI : MonoBehaviour
{
    [SerializeField] Button restartButton;
    [SerializeField] Button levelButton;
    [SerializeField] Button quitButton;

    // Start is called before the first frame update
    void Start()
    {
        restartButton.onClick.AddListener(OnRestart);
        levelButton.onClick.AddListener(OnLevel);
        quitButton.onClick.AddListener(OnQuit);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnRestart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    
    void OnLevel()
    {
        SceneManager.LoadScene("LevelScene");
    }

    void OnQuit()
    {
        SceneManager.LoadScene("StartScene");
    }
}
