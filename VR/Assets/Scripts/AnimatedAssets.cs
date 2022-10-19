using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class AnimatedAssets : MonoBehaviour
{

    Transform person;
    public Transform[] points;
    public int nextPoint = 1;
    public float rotationSpeed = 1.0f; // change this to what u think is good

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
            person.rotation = Quaternion.Slerp(person.rotation, Quaternion.LookRotation((points[nextPoint].position - person.position).normalized), Time.deltaTime * rotationSpeed);
        }
        else
        {
            nextPoint++;
            if (nextPoint > points.Length - 1)
            {
                // finished
                Destroy(gameObject);
            }
        }
    }
}