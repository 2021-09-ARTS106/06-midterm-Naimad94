using System.Collections;
using System.Collections.Generic;
public float forwardSpeed;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    private CharacterController controller;
    private VEctor3 direction;
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        direction.z = forwardSpeed;
    }

    private void FixedUpdate()
    {
        controller.Move(direction * TimeDeltaTime)
    }
}
