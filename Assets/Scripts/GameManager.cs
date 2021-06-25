using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public float restartDelay = 1;
    bool gameOver = false;

    public GameObject victoryUI;

    public void GameOver() 
    {
        if(gameOver == false)
        {
            gameOver = true;
            Invoke("Restart", restartDelay);
        }        
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Victory()
    {
        victoryUI.SetActive(true);
    }
}
