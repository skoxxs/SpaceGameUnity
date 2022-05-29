using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LivePlayer : MonoBehaviour
{
    [SerializeField] private int lives = 3;
    //[SerializeField] private int maxLives = 5;
    [SerializeField] private GameObject explosion;

    [SerializeField] private GameManager gameManager;

    [SerializeField] UnityEvent livesCheng;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public int GetLives()
    {
        return lives;
    }

    private void OnCollisionEnter(Collision collision)
    {
        
        Destroy(collision.gameObject);
        --lives;
        if(lives <= 0)
        {
            Instantiate(explosion, this.transform.position, explosion.transform.rotation);
            gameManager.PlayerDie();
            Destroy(this.gameObject);
        }
        livesCheng.Invoke();
    }
}
