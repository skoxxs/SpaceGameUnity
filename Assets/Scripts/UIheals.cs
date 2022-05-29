using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIheals : MonoBehaviour
{
    [SerializeField] private GameObject[] lives;
    [SerializeField] private LivePlayer _livePlayer;

    // Start is called before the first frame update
    void Start()
    {
        Updatelives();
    }

    private int hp;
    public void Updatelives()
    {
        if (_livePlayer == null) return;

        hp = _livePlayer.GetLives();

        for (int i = 0; i < lives.Length; i++)
        {
            if (i < hp) lives[i].SetActive(true);
            else lives[i].SetActive(false);
        }
    }
}
