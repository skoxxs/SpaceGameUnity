using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private CanvasControler canvasControler;
  
    public void GameWin()
    {
        PlayerPrefs.SetInt("level", PlayerPrefs.GetInt("level", 0) + 1);
        canvasControler.SelectWinPanel();
    }

    public void CloseAPK()
    {
        Application.Quit();
    }

    public void PlayerDie()
    {
        canvasControler.SelectLosePanel();
    }
}
