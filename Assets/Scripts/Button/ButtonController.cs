using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour {

    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void HightScore()
    {
        Debug.Log("Hight score.");
    }

    public void Option()
    {
        Debug.Log("Option.");
    }

    public void Tutorial()
    {
        Debug.Log("Tutorial.");
    }

    public void Market()
    {
        Debug.Log("Market.");
    }

    public void MoreGame()
    {
        Debug.Log("More Game.");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
