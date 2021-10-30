using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float speed;
    Vector3 direction;
    CharacterController controller;
    // Start is called before the first frame update
    void Awake()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        //input for movement
        Vector3 input = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        //direction vector taking rotation and speed into consideration
        direction = (transform.right * input.x + transform.forward * input.z).normalized * speed;
        //moving the Player using Character Controller
        controller.Move(direction * Time.deltaTime);
    }
}
