using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouvementRoue : MonoBehaviour
{
    private float travelSpeed;
    private float rotateSpeed;

    // Start is called before the first frame update
    void Start()
    {
        this.travelSpeed = 1.0f;
        this.rotateSpeed = 10.0f;
    }

    // Update is called once per frame

    // - UpArrow                    move forward
    // - DownArrow                  move backward
    // - LeftArrow                  rotate left
    // - RightArrow                 rotate right

    void Update()
    {
        // Forward movement
        if (Input.GetKey(KeyCode.UpArrow))
			this.transform.Translate(Vector3.forward * -this.travelSpeed * Time.deltaTime );

        // Moving backwards
        if (Input.GetKey(KeyCode.DownArrow))
			transform.Translate(Vector3.forward * this.travelSpeed * Time.deltaTime );

        // Displacement right
        if (Input.GetKey(KeyCode.LeftArrow))
			transform.Rotate(Vector3.up, Time.deltaTime * -rotateSpeed);

        // Left shift
        if (Input.GetKey(KeyCode.RightArrow))
			transform.Rotate(Vector3.up, Time.deltaTime * rotateSpeed);
    }
}
