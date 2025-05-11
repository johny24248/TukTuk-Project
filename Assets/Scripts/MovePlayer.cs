using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.EventSystems;

public class MovePlayer : MonoBehaviour
{
    public float speed = 10;
    private Vector3 playerpos;
    private float xpos;
    private bool MoveLeft = false;
    private bool MoveRight = false;
    public bool StopMove = false;
    float BrakeTimer = 0f;
    float BrakeDuration = 3f;
    public static bool IsBraking = false;
    // Start is called before the first frame update
    void Start()
    {
        xpos = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {

        if (BrakeTimer > 0f)
        {
            BrakeTimer -= Time.deltaTime;
            IsBraking = true;
        }
        else 
        {
            IsBraking = false;
        }
        Debug.Log($"BrakeTimer: {BrakeTimer}, IsBraking: {IsBraking}");
        if (transform.position.x > 0.8)
        {
            transform.position = new Vector3(0.8f, transform.position.y, transform.position.z);
        }
        else if (transform.position.x < -0.8)
        {
            transform.position = new Vector3(-0.8f, transform.position.y, transform.position.z);
        }
        if (MoveLeft)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        if (MoveRight)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
    }

    public void OnLeftButtonDown()
    {
        MoveLeft = true;
    }
    public void OnRightButtonDown()
    {
        MoveRight = true;
    }
    public void OnLeftButtonUp()
    {
        MoveLeft = false;
    }
    public void OnRightButtonUp()
    {
        MoveRight = false;
    }
    public void OnTapButtonDown()
    {
        BrakeTimer = BrakeDuration;
    }
    public void OnTapButtonUp()
    {
        IsBraking = false;
    }

}

    


