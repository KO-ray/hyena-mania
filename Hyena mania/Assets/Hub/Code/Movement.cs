using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Vector3 movement;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        movement.z = Input.GetAxis("Vertical");

        movement.x = Input.GetAxis("Horizontal");

        transform.Translate(movement * Time.deltaTime * speed);
    }
}
