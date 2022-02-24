using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseUI : MonoBehaviour
{
    [SerializeField] Button resumeButton;
    [SerializeField] Button restartButton;
    [SerializeField] Button mainMenuButton;
    [SerializeField] Button quitButton;

    // Start is called before the first frame update
    void Start()
    {
        resumeButton.onClick.AddListener(OnResume);
        restartButton.onClick.AddListener(OnRestart);
        mainMenuButton.onClick.AddListener(OnMainMenu);
        quitButton.onClick.AddListener(OnQuit);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnResume()
    {

    }

    void OnRestart()
    {

    }

    void OnMainMenu()
    { 

    }

    void OnQuit()
    {
        Application.Quit();
    }
}
