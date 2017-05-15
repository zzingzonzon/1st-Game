using UnityEngine;
using System.Collections;

public class EnemyAI : MonoBehaviour {

    public float patrolSpeed = 2f; // tốc độ enemy tuần tra
    public float patrolWaitTime = 1f;
    public Transform[] patrolWayPoint; // mảng vị trí mốc tuần tra

    private UnityEngine.AI.NavMeshAgent nav;
    private float patrolTimer;
    private int wayPointIndex;

	// Use this for initialization
	void Awake () {
        nav = GetComponent<UnityEngine.AI.NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update () {
        Patrolling();
	}

    private void Patrolling()
    {
        nav.speed = patrolSpeed;

        if (nav.remainingDistance < nav.stoppingDistance)
        {
            patrolTimer += Time.deltaTime;
            if (patrolTimer >= patrolWaitTime)
            {
                if (wayPointIndex == patrolWayPoint.Length - 1)
                    wayPointIndex = 0;
                else
                    wayPointIndex++;

                patrolTimer = 0;
            }
        }
        else
            patrolTimer = 0;

        nav.destination = patrolWayPoint[wayPointIndex].position;
    }
}
