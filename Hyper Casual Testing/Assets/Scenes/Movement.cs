using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody rb;
    public FixedJoystick joystick;
    public float Xspeed = 5f;
    public Transform player;

    // Start is called before the first frame update
    void Start()
    {
        speed = 5f;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float HorizontalInput = joystick.Horizontal;

        rb.velocity = new Vector3(HorizontalInput * Xspeed, rb.velocity.y, speed);
    }

    public void OnCollisionEnter(Collision other)
    {
        if (other.collider.CompareTag("Border"))
        {
            transform.localPosition = new Vector3(-1.3f, -1, player.position.z);
        }

        if (other.collider.CompareTag("Border2"))
        {
            transform.localPosition = new Vector3(4.1f, -1, player.position.z);
        }
    }
}