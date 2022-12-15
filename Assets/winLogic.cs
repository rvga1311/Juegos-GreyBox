using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class winLogic : MonoBehaviour
{
    public GameObject gameWinScreen;
    public GameObject player;
    public Text stateText;

    private void OnCollisionEnter2D(Collision2D other) 
    {
        gameWin();
    }

    public void gameWin()
    {
        player.SetActive(false);
        gameWinScreen.SetActive(true);
    }

    public void gameLose()
    {
        stateText.text = "You Lose!";
        player.SetActive(false);
        gameWinScreen.SetActive(true);
    }

    public void restartGame()
    {
        Debug.Log("Restarting Game");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


}
