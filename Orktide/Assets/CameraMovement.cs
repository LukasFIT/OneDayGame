using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {

    public float speed;
    public float rotateSpeed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        float r = Input.GetAxisRaw("Rotate");

        Vector3 forward = transform.forward * v;
        Vector3 side = transform.right * h;
        Vector3 movement = (forward + side).normalized;
        transform.position = transform.position + movement * Time.deltaTime * speed;

        transform.Rotate(Vector3.up, r * Time.deltaTime * rotateSpeed);
        //TODO: Infinite world (CIV globe)
    }
}
