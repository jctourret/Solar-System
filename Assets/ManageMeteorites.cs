using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class ManageMeteorites : MonoBehaviour
{
    public GameObject meteorPrefab;
    public Vector3 startPosition;
    public List<GameObject> meteors;
    public int meteorCount;
    public float meteorInterval;
    float timer;
    Vector3 offset;
    
    // Start is called before the first frame update
    void Start()
    {
        offset = new Vector3(3, 0, -2);
        for(int i = 0; i < meteorCount; i++)
        {
            GameObject meteor = Instantiate(meteorPrefab,startPosition,Quaternion.identity);
            meteor.transform.position -= offset * i;
            meteors.Add(meteor);
        }
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= meteorInterval)
        {
            for(int i = 0; i < meteors.Count; i++)
            {
                meteors[i].transform.position = startPosition;
                meteors[i].transform.position -= offset * i;
            }
            timer = 0f;
        }
    }
}
