using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float RestartDelay = 1f;
    bool gameHasEnded = false;
    public GameObject gameEndedUI;
    public void levelCompleted()
    {
        //Debug.Log("Completed");
        gameEndedUI.SetActive(true);
    }
    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game Over"); 
            Invoke("Restart", RestartDelay);
        }
    }
    private void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
