using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool GameHasEnded = false;
    public float RestartTimeout = 5f;

    public GameObject WinLevelUI;
    public PlayerMovement playerMovement;

    public void WinLevel()
    {
        if (GameHasEnded == false) {
            GameHasEnded = true;
            Debug.Log("LEVEL WON! CONGRATULATIONS!");
            WinLevelUI.SetActive(true);
            playerMovement.enabled = false;
        }
    }

    public void EndGame() {
        if (GameHasEnded == false)
        {
            GameHasEnded = true;
            Debug.Log("GAME OVER! YOU LOSE!");
            Invoke("Restart", RestartTimeout);
        }
    }
    public void Restart ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
