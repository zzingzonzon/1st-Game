using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FinishController : MonoBehaviour {

    public GameManager gameManager;
    public GameTextManager gameText;
    public EnemySight[] enemy;

    private Animator anim;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}

    // Update is called once per frame
    void Update()
    {

        if (gameManager.isWin)
        {
            gameText.isWin();
            anim.SetTrigger("isFinish");
        }
        foreach (EnemySight e in enemy)
        {
            if (e.isLose)
            {
                gameText.isLose();
                anim.SetTrigger("isFinish");
            }
        }
    }
}
