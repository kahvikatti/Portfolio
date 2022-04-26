using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Subtitles : MonoBehaviour
{
    public GameObject textBox;

    public Objectives objectives;
    public TVScript tvScript;
    public PlayerController playerController;

    public bool gameWon = false;
    
    void Start()
    {
        StartCoroutine(LivingRoomIntro());
    }

    void Update()
    {
        if (objectives.gameOver == true)
        {
            StartCoroutine(ChadGameOver());
        }

        if (gameWon == true)
        {
            StartCoroutine(LivingRoomSuccess());
        }

        if (tvScript.chadUpset == true)
        {
            StartCoroutine(ChadUpset());
            tvScript.chadUpset = false;
        }
    }

    IEnumerator LivingRoomIntro()
    {
        yield return new WaitForSeconds(1);
        textBox.GetComponent<Text>().text = "Chad: Hey bro! Guess whose turn it is to clean?";
        yield return new WaitForSeconds(3);
        textBox.GetComponent<Text>().text = "";
        yield return new WaitForSeconds(1);
        textBox.GetComponent<Text>().text = "Chad: The bin's in the corner. As always.";
        yield return new WaitForSeconds(3);
        textBox.GetComponent<Text>().text = "";
        yield return new WaitForSeconds(1);
        textBox.GetComponent<Text>().text = "Chad: I might've missed it a couple times though. Sorry about that.";
        yield return new WaitForSeconds(3);
        textBox.GetComponent<Text>().text = "";
        yield return new WaitForSeconds(1);
        textBox.GetComponent<Text>().text = "Chad: I'm counting on you bro!";
        yield return new WaitForSeconds(3);
        textBox.GetComponent<Text>().text = "";
    }

    IEnumerator ChadUpset()
    {
        textBox.GetComponent<Text>().text = "Chad: Yo what the heck bro! I was playing that!";
        playerController.TakeDamage(10);
        yield return new WaitForSeconds(3);
        textBox.GetComponent<Text>().text = "";
        yield return new WaitForSeconds(1);
        textBox.GetComponent<Text>().text = "Chad: ... I guess I'll pretend I'm still playing.";
        yield return new WaitForSeconds(3);
        textBox.GetComponent<Text>().text = "";

    }

    IEnumerator LivingRoomSuccess()
    {
        yield return new WaitForSeconds(1);
        textBox.GetComponent<Text>().text = "Chad: Heck yeah, this place is spotless!";
        yield return new WaitForSeconds(3);
        textBox.GetComponent<Text>().text = "";
        yield return new WaitForSeconds(1);
        textBox.GetComponent<Text>().text = "Chad: Nice job bro!";
        yield return new WaitForSeconds(3);
        textBox.GetComponent<Text>().text = "";
        objectives.Success();
    }

    IEnumerator ChadGameOver()
    {
        yield return new WaitForSeconds(1);
        textBox.GetComponent<Text>().text = "Chad: Uhh bro? Are you okay? You're acting weird...";
        yield return new WaitForSeconds(3);
        textBox.GetComponent<Text>().text = "";
        objectives.gameOverPanel.SetActive(true);
        Time.timeScale = 0;
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
    }
}
