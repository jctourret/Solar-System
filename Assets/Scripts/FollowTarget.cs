using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTarget : MonoBehaviour
{
    public GenerateGalaxy manager;
    public ShipController ship;
    bool followPlayer;
    int target;
    Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = new Vector3(0, -5, 5);
        transform.position = manager.system[0].transform.position - offset;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1)) { target = 1; followPlayer = false; };
        if (Input.GetKeyDown(KeyCode.Alpha2)) { target = 2; followPlayer = false; };
        if (Input.GetKeyDown(KeyCode.Alpha3)) { target = 3; followPlayer = false; };
        if (Input.GetKeyDown(KeyCode.Alpha4)) { target = 4; followPlayer = false; };
        if (Input.GetKeyDown(KeyCode.Alpha5)) { target = 5; followPlayer = false; };
        if (Input.GetKeyDown(KeyCode.Alpha6)) { target = 6; followPlayer = false; };
        if (Input.GetKeyDown(KeyCode.Alpha7)) { target = 7; followPlayer = false; };
        if (Input.GetKeyDown(KeyCode.Alpha8)) { target = 8; followPlayer = false; };
        if (Input.GetKeyDown(KeyCode.Alpha0)) { target = 0; followPlayer = false; };
        if (Input.GetKeyDown(KeyCode.P)){ followPlayer = true; }
        if (!followPlayer)
        {
            transform.position = manager.system[target].transform.position - offset;
        }
        else
        {
            transform.position = ship.transform.position - offset; 
        }
    }
}
