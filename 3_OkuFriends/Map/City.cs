using System.Collections;
using System.Collections.Generic;
using GoShared;
using System.Linq;
using UnityEngine;

public class City : MonoBehaviour
{
    public GameObject[] cityPrefab;
    public Coordinates[] coordinates;
    Vector3 position;
    GameObject city;


    private void Start()
    {
        Invoke("LateStart", .5f);
    }

    //Instantiates the city centre of Outokumpu on the map based on real world coordinates using GO Map.
    void LateStart()
    {
        int i = 0;
        foreach (GameObject prefab in cityPrefab)
        {
            city = Instantiate(prefab) as GameObject;
            position = coordinates[i].convertCoordinateToVector();
            keskusta.transform.position = position;
            i++;
        }
    }
}