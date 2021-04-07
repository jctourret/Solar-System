using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planets : MonoBehaviour
{
    Color planetColor;
    Transform sun;
    public int orbitSpeed = 50;
    public void Start()
    {
        planetColor = GetComponent<Renderer>().material.color;
        sun = this.transform.parent;
    }
    void Update()
    {
        transform.RotateAround(sun.transform.position, Vector3.up, orbitSpeed * Time.deltaTime);
        transform.Rotate(Vector3.up);
    }
    private void OnTriggerEnter(Collider collider)
    {
        Debug.Log("Collided");

        if (collider.gameObject.tag == "Player")
        {
            // Ejemplo de Struct vs Class.
            planetColor.a = 0.3f;
            GetComponent<Renderer>().material.color = planetColor;
            Debug.Log("Collided with " + collider.name);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (planetColor.a < 1)
        {
            planetColor.a = 1;
            GetComponent<Renderer>().material.color = planetColor;
        }
    }
}
