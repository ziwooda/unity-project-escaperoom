using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {
    Rigidbody rb;
    Animator am;
    float speed = 30f;
    float x, y;
    bool isRun;
    bool isRotate;

    void Start() {
        rb = GetComponent<Rigidbody>();
        am = GetComponent<Animator>();
    }
    void Update() {
        x = Input.GetAxis("Vertical");
        if (x != 0) isRun = true;
        else isRun = false;

        y = Input.GetAxis("Horizontal");
        if (y != 0) isRotate = true;
        else isRotate = false;
    }
    void FixedUpdate() {
        Turn();
        Run();
    }
    void Run() {
        if (isRun == false) return;
        Vector3 movement = x * Vector3.forward * speed * Time.deltaTime;
        transform.Translate(movement);
    }
    void Turn() {
        if (isRotate == false) return;
        Vector3 rotation = new Vector3(0f, y * speed * Time.deltaTime, 0f);
        transform.Rotate(rotation);
    }
}
