using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject Target = null;
    public GameObject T = null;
    public float speed = 1.5f;
    public int index;

    // Start is called before the first frame update
    void Start()
    {
        Target = GameObject.FindGameObjectWithTag("Player");
        T = GameObject.FindGameObjectWithTag("Target");

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        this.transform.LookAt(Target.transform);
        float carMove = Mathf.Abs(Vector3.Distance(this.transform.position, T.transform.position) * speed);
        this.transform.position = Vector3.MoveTowards(this.transform.position, T.transform.position, carMove * Time.deltaTime);
    }
}
