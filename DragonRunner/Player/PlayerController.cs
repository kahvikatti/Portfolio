using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Animator m_Animator;
    public float jumpPower = 500;
    public bool canJump = false;
    public float speed = 10f;
    public Transform left, middle, right, current;
    GameManager gameManager;

    void Start()
    {
        m_Animator = gameObject.GetComponent<Animator>();
        current = middle;
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    //Player movement between three lanes & jump
    void Update()
    {
        if (Input.GetButtonDown("Jump") && canJump)
        {
            m_Animator.SetTrigger("Jump");
            GetComponent<Rigidbody>().AddForce(Vector3.up * jumpPower);
        }

        transform.position = Vector3.Lerp(transform.position, new Vector3(current.position.x, transform.position.y, current.position.z), 10f * Time.deltaTime);

        if ((Input.GetKeyDown(KeyCode.LeftArrow) && current == middle && canJump && gameManager.isGameActive))
        {
            current = left;
        }

        if ((Input.GetKeyDown(KeyCode.LeftArrow) && current == right && canJump && gameManager.isGameActive))
        {
            current = middle;
        }

        if ((Input.GetKeyDown(KeyCode.RightArrow) && current == middle && canJump && gameManager.isGameActive))
        {
            current = right;
        }

        if ((Input.GetKeyDown(KeyCode.RightArrow) && current == left && canJump && gameManager.isGameActive))
        {
            current = middle;
        }
    }

    //Check if player is airborne
    void FixedUpdate()
    {
        RaycastHit hit;

        if (Physics.Raycast(transform.position, Vector3.down, out hit, 0.2f))
        {
            if(hit.transform.tag == "Ground")
            {
                canJump = true;
            }
        }

        if (!Physics.Raycast(transform.position, Vector3.down, out hit, 0.2f))
        {
            canJump = false;
        }
    }
}
