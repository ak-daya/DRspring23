using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleHandler : MonoBehaviour
{
    AutoNavigation navigator;
    CollisionAvoidance collisionAvoider;
    protected float startTime;
    protected float threshold;


    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
        threshold = 15f;
    }

    // Update is called once per frame
    void Update()
    {
        if (collisionAvoider.DetectObstacle())
        {
            if (Time.time - startTime > threshold)
            {
                // Display UI and clickables
                    
                // 
            }
        }
    }
}
