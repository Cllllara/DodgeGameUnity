using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{
    public void GoToMenu ()
    {
        SceneManager.LoadScene("MainMenu");
    }

}
