using UnityEngine.SceneManagement;
using UnityEngine;

public class Mena : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
