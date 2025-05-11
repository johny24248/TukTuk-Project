using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Traffic : MonoBehaviour
{
    public float speed = 15f;
    public MovePlayer MovePlayer;
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
            currentSpeed *= 0.2f;
        }
        transform.Translate(Vector3.back * currentSpeed * Time.deltaTime);
        if(transform.position.z < -10)
        {
            Destroy(gameObject);
        }
    }
}
