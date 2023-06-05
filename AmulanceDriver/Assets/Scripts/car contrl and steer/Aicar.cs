using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aicar : MonoBehaviour
{
    [SerializeField] private float distanceThreshold = 0.1f;
    [SerializeField] private Cwaypoint waypoint;

    [SerializeField] private float rotateSpeed = 4f;

    [SerializeField] private float moveSpeed = 5f;
    // Start is called before the first frame update

    private Transform currentWaypoint;


    //rotation
    private Quaternion rotationGoal;
    private Vector3 directionToWaypoint;
    void Start()
    {
        // set intial position
        currentWaypoint = waypoint.GetNextWaypoint(currentWaypoint);
        transform.position = currentWaypoint.position;

        currentWaypoint = waypoint.GetNextWaypoint(currentWaypoint);
        transform.LookAt(currentWaypoint);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, currentWaypoint.position, moveSpeed * Time.deltaTime);
        if (Vector3.Distance(transform.position, currentWaypoint.position) < distanceThreshold)
        {
            currentWaypoint = waypoint.GetNextWaypoint(currentWaypoint);
            // transform.LookAt(currentWaypoint);
        }
        RotateTowardsWaypoint();
    }


    private void RotateTowardsWaypoint()
    {
        directionToWaypoint = (currentWaypoint.position - transform.position).normalized;
        rotationGoal = Quaternion.LookRotation(directionToWaypoint);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotationGoal, rotateSpeed * Time.deltaTime);
    }
}
