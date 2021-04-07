using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateGalaxy : MonoBehaviour
{
    public List<string> planetNames;
    public List<Material> planetMats;
    public List<GameObject> system;
    public int numberOfPlanets = 8;
    public GameObject sunPrefab;
    public GameObject planetPrefab;
    public Material sunMat;
    public Material trailMat;
    GameObject sun;
    int planetsInPlace;
    float minPlanetSize = 0.5f;
    float maxPlanetSize = 2.5f;
    Vector3 sunOffset = Vector3.forward*3;

    private void Awake()
    {
        sun = GameObject.Instantiate(sunPrefab, Vector3.up, Quaternion.identity);
        system.Add(sun);
        sun.name = "Sun";
        sun.GetComponent<Renderer>().material = sunMat;
        for (int i = 0; i < numberOfPlanets; i++) {
            int random = Random.Range(0, planetNames.Count);
            GameObject planet = GameObject.Instantiate(planetPrefab, sun.transform.position+sunOffset, sun.transform.rotation);
            planet.transform.parent = sun.transform;
            planet.name = planetNames[random];
            planet.GetComponent<Renderer>().material = planetMats[random];
            planet.AddComponent<TrailRenderer>();
            planet.GetComponent<TrailRenderer>().material = trailMat;
            planet.transform.localScale = planet.transform.localScale * Random.Range(minPlanetSize, maxPlanetSize);
            system.Add(planet);
            sunOffset += Vector3.forward*2;
        }
        planetsInPlace = numberOfPlanets;
    }
    // Update is called once per frame
    void Update()
    {
      if (planetsInPlace != numberOfPlanets)
        {

        }   
    }
}
