using UnityEngine;
using UnityEngine.SceneManagement;

public class credits : MonoBehaviour
{
    public void Quit ()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }

    public void RestartGame ()
    {
        SceneManager.LoadScene(sceneBuildIndex: 1);
    }
}
