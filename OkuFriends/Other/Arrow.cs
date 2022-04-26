using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{

    public GameObject[] waypoint;
    public int waypointNumber;

    public Transform waypointArrow;
    public GameObject target;
    public GameObject currentWP;

    [Range(0.0001f, 20)] public float arrowTargetSmooth;

    void Awake()
    {
        if (ES3.KeyExists("waypointNumber2"))
            waypointNumber = ES3.Load<int>("waypointNumber2");
    }

    void Start()
    {
        Invoke("LateStart", .6f);
    }

    void LateStart()
    {
        waypoint[0] = GameObject.Find("Kaupungintalo(Clone)");
        waypoint[1] = GameObject.Find("KulmaKahvila(Clone)");
        waypoint[2] = GameObject.Find("Kirjakauppa(Clone)");
        waypoint[3] = GameObject.Find("Kaivos(Clone)");
        waypoint[4] = GameObject.Find("LaMilano(Clone)");
        waypoint[5] = GameObject.Find("KummunKoulu(Clone)");
        waypoint[6] = GameObject.Find("Kirjasto(Clone)");
        waypoint[7] = GameObject.Find("UrheilutaloUimahalli(Clone)");
        waypoint[8] = GameObject.Find("Kaupungintalo(Clone)");

        target = waypoint[waypointNumber];
        currentWP = target;
    }

    //Arrow always points to the next waypoint.
    void Update()
    {
        currentWP = target;

        if (target != null)
        {
            target.transform.position = Vector3.Lerp(target.transform.position, currentWP.transform.position, arrowTargetSmooth * Time.deltaTime);
            target.transform.rotation = Quaternion.Lerp(target.transform.rotation, currentWP.transform.rotation, arrowTargetSmooth * Time.deltaTime);
        }
        waypointArrow.LookAt(target.transform);
    }

    public void ChangeTarget()
    {
        waypointNumber++;

        if (waypointNumber == 0)
        {
            target = waypoint[0];
            ES3.Save("waypointNumber2", 0);
        }
        if (waypointNumber == 1)
        {
            target = waypoint[1];
            ES3.Save("waypointNumber2", 1);
        }
        if (waypointNumber == 2)
        {
            target = waypoint[2];
            ES3.Save("waypointNumber2", 2);
        }
        if (waypointNumber == 3)
        {
            target = waypoint[3];
            ES3.Save("waypointNumber2", 3);
        }
        if (waypointNumber == 4)
        {
            target = waypoint[4];
            ES3.Save("waypointNumber2", 4);
        }
        if (waypointNumber == 5)
        {
            target = waypoint[5];
            ES3.Save("waypointNumber2", 5);
        }
        if (waypointNumber == 6)
        {
            target = waypoint[6];
            ES3.Save("waypointNumber2", 6);
        }
        if (waypointNumber == 7)
        {
            target = waypoint[7];
            ES3.Save("waypointNumber2", 7);
        }
        if (waypointNumber == 8)
        {
            target = waypoint[8];
            ES3.Save("waypointNumber2", 8);
        }
        if (waypointNumber == 9)
        {
            target = waypoint[0];
            ES3.Save("waypointNumber2", 9);
        }

    }
}
