using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class StopManager : MonoBehaviour
{
        Animator anim;
        public Transform Player;
        public Transform Stop;
        public float InteractionDistance = 50;
        public AudioClip error1;
        public AudioClip minifanfare;
        public AudioClip finalfanfare;
        public AudioSource audioSource;
        NotebookManager notebookManager;
        DialogueManager dialogueManager;
        WaypointController waypointController;
        Arrow arrow;

        void Start()
        {
            Player = GameObject.Find("GoMap Character").transform;
            anim = gameObject.GetComponent<Animator>();
            audioSource = GameObject.Find("SoundEffects").GetComponent<AudioSource>();
            notebookManager = GameObject.Find("GameObject").GetComponent<NotebookManager>();
            dialogueManager = GameObject.Find("GameObject").GetComponent<DialogueManager>();
            waypointController = GameObject.Find("Waypoint Controller").GetComponent<WaypointController>();
            arrow = GameObject.Find("Arrow").GetComponent<Arrow>();
        }

    //On click, check player's distance from stop and what item player has. If distance and item match, trigger next piece of dialogue using Fungus, reveal next sticker, change waypoints, and save player's progress using Easy Save.
    void OnMouseDown()
        {
            float distanceFromPlayer = Vector3.Distance(Stop.position, Player.position);

            if (!EventSystem.current.IsPointerOverGameObject())
            {
                if (distanceFromPlayer < InteractionDistance && Input.GetMouseButtonDown(0))
                {
                    if (GetComponent<Item>().itemTypeCheck.Equals(GameObject.Find("GoMap Character").GetComponent<Item>().itemType))
                    {
                        audioSource.PlayOneShot(minifanfare);
                        GameObject.Find("GoMap Character").GetComponent<Item>().itemType = GetComponent<Item>().itemType;
                        dialogueManager.ChangeDialogue();
                        notebookManager.GetSticker();
                        arrow.ChangeTarget();
                        waypointController.ChangeTarget();
                        waypointController.SaveWaypoint();
                        anim.SetTrigger("SpinStop");
                    }
                    else if (GetComponent<Item>().lastItemCheck.Equals(GameObject.Find("GoMap Character").GetComponent<Item>().itemType))
                    {
                        audioSource.PlayOneShot(finalfanfare);
                        dialogueManager.ChangeDialogue();
                        notebookManager.GetLastSticker();
                        anim.SetTrigger("SpinStop");
                    }
                    //Clicking wrong stop triggers dialogue using Fungus based on which item the player currently has
                    else
                    {
                        audioSource.PlayOneShot(error1);
                        dialogueManager.WrongStop(GameObject.Find("GoMap Character").GetComponent<Item>().itemType);
                    }
                }
            }
        }
}