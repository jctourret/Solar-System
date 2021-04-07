using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorMovement : MonoBehaviour
{
    public float meteorSpeed = 10;
    Vector3 direction;
    Vector3 scaleDamage;
    // Start is called before the first frame update
    void Start()
    {
        direction = new Vector3(-1f, 0f, -1f);
        scaleDamage = new Vector3(0.2f,0.2f,0.2f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += direction * meteorSpeed * Time.deltaTime;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Planet")
        {
            other.transform.localScale -= scaleDamage;
            if (other.transform.localScale.x < 0 || other.transform.localScale.y < 0 || other.transform.localScale.z < 0)
            {
                other.transform.localScale = new Vector3(0, 0, 0);
            }
            Debug.Log("Meteor Collided With Planet");
        }
    }
}
