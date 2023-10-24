using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //Variables

    public float speed;

    private Rigidbody playerRigidBody;


    // Start is called before the first frame update
    void Start()
    {
        playerRigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        playerRigidBody.transform.Translate(Vector3.forward * speed * verticalInput * Time.deltaTime);
        playerRigidBody.transform.Translate(Vector3.right * speed * horizontalInput * Time.deltaTime);
    }
}
