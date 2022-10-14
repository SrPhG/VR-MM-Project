using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class AnimatedAssets : MonoBehaviour
{

    public Transform person;
    public Transform myStartPoint;
    public Transform myEndPoint;
    public Transform[] points;
    public int nextPoint = 1;

    public float speed;

    bool isReversing = false;

    // Start is called before the first frame update
    void Start()
    {
        person.position = points[0].position;
    }

    // Update is called once per frame
    void Update()
    {
        //person.position = Vector3.MoveTowards(person.position, myEndPoint.position, speed);



        if (isReversing == false)
        {
            person.position = Vector3.MoveTowards(person.position, points[nextPoint].position, speed);

            if (person.position == points[nextPoint].position)
            {
                if (points.Length > nextPoint-1)
                {
                    nextPoint++;
                }
                //isReversing = true;
            }
        }
        else
        {
            person.position = Vector3.MoveTowards(person.position, points[0].position, speed);

            if (person.position == points[0].position)
            {
                isReversing = false;
            }
        }
    }
}
