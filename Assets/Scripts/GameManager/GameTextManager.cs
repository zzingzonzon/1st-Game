using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameTextManager : MonoBehaviour {

    private Text text;

    void Awake()
    {
        text = GetComponent<Text>();
    }

    public void isWin()
    {
        text.text = "You win!";
    }

    public void isLose()
    {
        text.text = "You lose!";
    }
}
