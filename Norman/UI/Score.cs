using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int pizzaScoreValue = 0;
    public Text pizzaScore;
    public static int drinkScoreValue = 0;
    public Text drinkScore;

    Objectives objectives;
    Subtitles subtitles;

    void Start()
    {
        objectives = GetComponent<Objectives>();
        subtitles = GetComponent<Subtitles>();
    }

    void Update()
    {
        pizzaScore.text = pizzaScoreValue + "/10";
        drinkScore.text = drinkScoreValue + "/10";

        if (pizzaScoreValue == 10 && drinkScoreValue == 10)
        {
            subtitles.gameWon = true;
        }
    }
}
