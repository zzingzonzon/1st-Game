using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

    public GameObject player;

    public bool isFinish;
    public bool isWin;

    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }


    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject == player)
        {
            isFinish = true;
            isWin = true;
        }
    }
}
