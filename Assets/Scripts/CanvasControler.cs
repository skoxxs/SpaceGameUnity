using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class CanvasControler : MonoBehaviour
{
    [Header ("Panel:")]
    [SerializeField] private GameObject mainMenu;
    [SerializeField] private GameObject play;
    [SerializeField] private GameObject pause;
    [SerializeField] private GameObject win;
    [SerializeField] private GameObject lose;

    [SerializeField] private TextMeshProUGUI levelText;


    [SerializeField] private UnityEvent StartGame;

    void Start()
    {
        levelText.text = "Level: " + PlayerPrefs.GetInt("level",0);
        resetAllPanels();
        mainMenu.SetActive(true);
    }

    private void resetAllPanels()
    {
        mainMenu.SetActive(false);
        play.SetActive(false);
        pause.SetActive(false);
        win.SetActive(false);
        lose.SetActive(false);
    }

    public void SelectMainMenuPanel()
    {
        SceneManager.LoadScene(0);
    }

    public void SelectPlayPanel()
    {
        resetAllPanels();
        play.SetActive(true);
        StartGame.Invoke();
    }

    public void SelectPausePanel()
    {
        resetAllPanels();
        pause.SetActive(true);
    }

    public void SelectWinPanel()
    {
        resetAllPanels();
        win.SetActive(true);
    }

    public void SelectLosePanel()
    {
        resetAllPanels();
        lose.SetActive(true);
    }
 
}
