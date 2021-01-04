using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    public float speed;
    public Transform[] MoveSpots;
    public float StartWaitTime;
    private int RandomSpot;
    private float WaitTime;
    // Start is called before the first frame update
    void Start()
    {
        WaitTime = StartWaitTime;
        //RandomSpot = Random.Range(0, MoveSpots.Length);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position,MoveSpots[RandomSpot].position,speed * Time.deltaTime);
        if(Vector3.Distance(transform.position, MoveSpots[RandomSpot].position) < 0.2f)
        {
            if(WaitTime <= 0)
            {
                RandomSpot = Random.Range(0, MoveSpots.Length);
                WaitTime = StartWaitTime;
            }
            else
            {
                WaitTime -= Time.deltaTime;
            }
        }
    }
}
