using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadScript : MonoBehaviour
{
    private Vector3 Road;
    private float speed = 10f;
    private Vector3 roadpos;
    public MovePlayer MovePlayer;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float currentSpeed = speed;
        if(MovePlayer.IsBraking)
        {
            currentSpeed *= 0.15f;
        }
        roadpos.z -= currentSpeed * Time.deltaTime;

        if (roadpos.z < -40)
        {
            roadpos.z = 116;
        }

    }
}
