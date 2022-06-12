using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float forwardSpeed = 10f;
    [SerializeField] private float sideSpeed = 10f;
    [SerializeField] private float limit = 2.4f;

    private float forward = 0f;


    // Update is called once per frame
    void Update()
    {
        float side = Input.GetAxisRaw("Horizontal") * sideSpeed * Time.deltaTime;

        if (Input.GetKey(KeyCode.W))
        {
            forward = 1f;
        }
        else
        {
            forward = 0f;
        }

        GetComponent<Rigidbody>().velocity = Vector3.ClampMagnitude(new Vector3(side, 0f, forward * forwardSpeed * Time.deltaTime),8f);
        if (transform.position.x <= -limit)
        {
            Vector3 _position = new Vector3(-limit, transform.position.y, transform.position.z);
            transform.position = _position;
        }
        else if (transform.position.x >= limit)
        {
            Vector3 _position = new Vector3(limit, transform.position.y, transform.position.z);
            transform.position = _position;
        }
    }
}
