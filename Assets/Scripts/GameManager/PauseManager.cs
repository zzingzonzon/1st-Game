using UnityEngine;
using System.Collections;

public class PauseManager : MonoBehaviour {

    public GameObject pausePanel;

    public bool isPause;
    // Use this for initialization
    void Awake()
    {
        isPause = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isPause)
            PauseGame(true);
        else
            PauseGame(false);

        if (Input.GetButtonDown("Cancel"))
            switchState();
    }

    public void PauseGame(bool state)
    {
        if (state)
            Time.timeScale = 0.0f;
        else
            Time.timeScale = 1.0f;

        pausePanel.SetActive(state);
    }

    public void switchState()
    {
        if (isPause)
            isPause = false;
        else
            isPause = true;
    }
}
