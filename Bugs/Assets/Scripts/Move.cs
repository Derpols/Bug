using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 2f;
    public GameObject player;
    public int posX;
    public int posY;
    public int posZ;
    // Need to make it easier to move around.

    public void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.D))
            transform.position += Time.deltaTime * _moveSpeed * transform.right;
        else
        if (Input.GetKey(KeyCode.A))
            transform.position += Time.deltaTime * _moveSpeed * (-transform.right);
        else
        if (Input.GetKey(KeyCode.W))
            transform.position += Time.deltaTime * _moveSpeed * transform.forward;
        else
        if (Input.GetKey(KeyCode.S))
            transform.position += Time.deltaTime * _moveSpeed * (-transform.forward);
        else
        if (Input.GetKeyDown(KeyCode.Space))
            transform.position = new Vector3(transform.position.x, transform.position.y + 0.5f, transform.position.z);
    }
}
