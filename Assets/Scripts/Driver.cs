using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField]float steerSpeed = 200f;
    [SerializeField]float moveSpeed = 10f;

    void Start()
    {

    }

    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal")*steerSpeed;
        float moveAmount = Input.GetAxis("Vertical")*moveSpeed;

        transform.Rotate(0,0,-steerAmount*Time.deltaTime);
        transform.Translate(0,moveAmount*Time.deltaTime,0);
    }
}
