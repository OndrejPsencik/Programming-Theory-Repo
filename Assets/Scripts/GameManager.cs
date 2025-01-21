using UnityEngine;

public class GameManager : MonoBehaviour
{
    public void ShowGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    }

}
