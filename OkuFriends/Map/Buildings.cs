using System.Collections;
using System.Collections.Generic;
using GoShared;
using System.Linq;
using UnityEngine;

public class Buildings : MonoBehaviour
{
        public GameObject[] buildingPrefab;
        public Coordinates[] coordinates;
        Vector3 position;
        GameObject stop;
        WaypointController waypointController;

        void Awake()
        {
            waypointController = GameObject.Find("Waypoint Controller").GetComponent<WaypointController>();
            waypointController.LoadWaypoint();
        }

        private void Start()
        {
            Invoke("LateStart", .5f);
        }

        //Instantiate building prefabs on map based on their real world coordinates using GO Map.
        void LateStart()
        {
            int i = 0;
            foreach (GameObject building in buildingPrefab)
            {
                stop = Instantiate(building) as GameObject;
                position = coordinates[i].convertCoordinateToVector();
                stop.transform.position = position;
                i++;
            }
        }
}
