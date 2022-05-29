using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private CanvasControler canvasControler;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
  
    public void GameWin()
    {
        PlayerPrefs.SetInt("level", PlayerPrefs.GetInt("level", 0) + 1);
        canvasControler.SelectWinPanel();
    }

    public void CloseAPK()
    {
        
        Application.Quit();
        Debug.Log("Game is exiting");
    }

    public void PlayerDie()
    {
        canvasControler.SelectLosePanel();
    }
}
