using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class winLogic : MonoBehaviour
{
    public GameObject gameWinScreen;
    public GameObject player;

    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag == "Player") {
            gameWin();
        }
    }

    public void gameWin()
    {
        player.SetActive(false);
        gameWinScreen.SetActive(true);
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


}
