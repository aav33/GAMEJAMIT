using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void LoadGame()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void OpenOptions()
    {
        SceneManager.LoadScene("optionsmenu");
    }

    public void OpenCredits()
    {
        SceneManager.LoadScene("creditsmenu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
