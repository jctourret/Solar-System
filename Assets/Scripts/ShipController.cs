using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour
{
    Color shipColors;
    Vector3 rotation;
    public int directionSpeed = 100;
    public float turninSpeed = 50;
    float hor;
    float ver;
    private void Start()
    {
        shipColors = GetComponent<Renderer>().material.color;
    }
    void Update()
    {
        hor = Input.GetAxis("Horizontal");
        ver = Input.GetAxis("Vertical");

        rotation = new Vector3(0, hor, 0);
        transform.position += transform.forward * ver * directionSpeed * Time.deltaTime;
        transform.Rotate(rotation*turninSpeed*Time.deltaTime);
    }
    private void OnTriggerEnter(Collider collider)
    {
        Debug.Log("Collided");
        if (collider.gameObject.tag == "Planet")
        {
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (shipColors.a < 1) {
        }
    }
}
