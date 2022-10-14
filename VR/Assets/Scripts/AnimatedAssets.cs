using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class AnimatedAssets : MonoBehaviour
{

    Transform person;
    public Transform[] points;
    public int nextPoint = 1;

    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        person = transform;
        person.position = points[0].position;
    }

    // Update is called once per frame
    void Update()
    {
        if (person.position != points[nextPoint].position)
        {
            person.position = Vector3.MoveTowards(person.position, points[nextPoint].position, speed);

            if (person.position == points[nextPoint].position)
            {
                if (points.Length > nextPoint+1)
                {
                    nextPoint++;
                }
            }
        }
        else
        {
            Destroy(person.gameObject);
        }
    }
}
