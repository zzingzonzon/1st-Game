using UnityEngine;
using System.Collections;

public class EnemySight : MonoBehaviour {

    public float fieldOfViewAngle = 110f;

    private GameObject player;
    private bool playerInRange = false;
    private SphereCollider col;
    public bool isLose;

	// Use this for initialization
	void Awake () {
        player = GameObject.FindGameObjectWithTag("Player");
        col = GetComponent<SphereCollider>();
	}
	
	// Update is called once per frame
	void Update () {
        if (playerInRange)
        {
            isLose = true;
        }
	}

    //void OnTriggerEnter(Collider collider)
    //{
    //    if (collider.gameObject == player)
    //        playerInRange = true;
    //}

    void OnTriggerStay(Collider collider)
    {
        if (collider.gameObject == player)
        {
            playerInRange = false;
            Vector3 dicrection = collider.transform.position - transform.position;
            float angle = Vector3.Angle(dicrection, transform.forward);

            if (angle < fieldOfViewAngle * 0.5f)
            {
                RaycastHit hit;
                if (Physics.Raycast(transform.position + transform.up, dicrection.normalized, out hit, col.radius))
                {
                    if (hit.collider.gameObject == player)
                        playerInRange = true;
                }
            }
        }
    }
}
