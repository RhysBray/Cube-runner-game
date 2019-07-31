using UnityEngine;

public class WinLevelTrigger : MonoBehaviour
{
    public GameManager gameManager;

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.name == "Player") {
            gameManager.WinLevel();
        }
    }
}
