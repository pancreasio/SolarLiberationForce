using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody rig;
    public float speed;

    private void Start()
    {

    }

    private void Update()
    {
        Debug.Log(rig.velocity);
    }

    private void FixedUpdate()
    {
        transform.position = new Vector3 (transform.position.x + Input.GetAxisRaw("Horizontal") * speed,
                                          transform.position.y,
                                          transform.position.z + Input.GetAxisRaw("Vertical") * speed);
    }
}
