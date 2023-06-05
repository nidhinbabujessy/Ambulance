/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum Cm { keyboard = 1, Touch = 2};

public class InputSystem : MonoBehaviour
{

    public Cm control;
    public float Accel;
    public float Brake;
    public float Rev;
    public float steering;
    public GameObject UI;

    public void AccelInput(float input) { Accel = input; }
    public void BrakeInpu(float input) { Brake = input; }
    public void RevInput(float input) {Rev = input; }
    // Start is called before the first frame update

    carrC car;

   void Start()
    {
        car = GetComponent<carrC>();
    }

    // Update is called once per frame
    void Update()
    {
        if (control == Cm.keyboard)
        {
            Accel = Input.GetAxis("Vertical");
            Brake = Input.GetAxis("Jump");
            steering = Input.GetAxis("Horizontal");
            UI.SetActive(false);
        }
        else
        {
            UI.SetActive(true);
        }
    }
    private void FixedUpdate()
    {

        car.motorT(Accel, Brake);
    }
}
*/