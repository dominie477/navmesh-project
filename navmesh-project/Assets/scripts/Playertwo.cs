using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playertwo : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 10f;


    // Start is called before the first frame update
    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        controller.Move(Physics.gravity * Time.deltaTime);


    }
   
}
