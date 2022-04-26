using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Fungus;

public class DialogueManager : MonoBehaviour
{

    public int dialogueNumber = 0;
    Item item;
    public bool inOku;
    public Flowchart flowchart;

    void Start()
    {
        flowchart = GameObject.Find("Flowchart").GetComponent<Flowchart>();
        item = GameObject.FindWithTag("Player").GetComponent<Item>();
        if(ES3.KeyExists("dialogueNumber"))
        dialogueNumber = ES3.Load<int>("dialogueNumber");
    }


    //Triggers new dialogue using Fungus when correct stop is clicked. Saves player's progress using Easy Save.
    public void ChangeDialogue()
    {
        dialogueNumber++;
            if (dialogueNumber == 1)
            {
                ES3.Save("dialogueNumber", 1);
            }
            else if (dialogueNumber == 2)
            {
                Fungus.Flowchart.BroadcastFungusMessage("Kaupungintalo");
                ES3.Save("dialogueNumber", 2);
            }
            else if (dialogueNumber == 3)
            {
                Fungus.Flowchart.BroadcastFungusMessage("Kahvila");
                ES3.Save("dialogueNumber", 3);
            }
            else if (dialogueNumber == 4)
            {
                Fungus.Flowchart.BroadcastFungusMessage("Kirjakauppa");
                ES3.Save("dialogueNumber", 4);
            }
            else if (dialogueNumber == 5)
            {
                Fungus.Flowchart.BroadcastFungusMessage("Kaivos");
                ES3.Save("dialogueNumber", 5);
            }
            else if (dialogueNumber == 6)
            {
                Fungus.Flowchart.BroadcastFungusMessage("LaMilano");
                ES3.Save("dialogueNumber", 6);
            }
            else if (dialogueNumber == 7)
            {
                Fungus.Flowchart.BroadcastFungusMessage("Kummunkoulu");
                ES3.Save("dialogueNumber", 7);
            }
            else if (dialogueNumber == 8)
            {
                Fungus.Flowchart.BroadcastFungusMessage("Kirjasto");
                ES3.Save("dialogueNumber", 8);
            }
            else if (dialogueNumber == 9)
            {
                Fungus.Flowchart.BroadcastFungusMessage("Uimahalli");
                ES3.Save("dialogueNumber", 9);
            }
            else if (dialogueNumber == 10)
            {
                Fungus.Flowchart.BroadcastFungusMessage("END");
                ES3.Save("dialogueNumber", 10);
            }
    }


    //Triggers dialogue using Fungus when incorrect stop is clicked.
    public void WrongStop(Item.ItemType item)
    {
        if (item == Item.ItemType.Kuvernööri)
        {
            Fungus.Flowchart.BroadcastFungusMessage("KuvernooriWrong");
        }
        else if (item == Item.ItemType.Ooretti)
        {
            Fungus.Flowchart.BroadcastFungusMessage("OorettiWrong");
        }
        else if (item == Item.ItemType.JP)
        {
            Fungus.Flowchart.BroadcastFungusMessage("JPWrong");
        }
        else if (item == Item.ItemType.KebabJuha)
        {
            Fungus.Flowchart.BroadcastFungusMessage("KebabJuhaWrong");
        }
        else if (item == Item.ItemType.Päppis)
        {
            Fungus.Flowchart.BroadcastFungusMessage("PappisWrong");
        }
        else if (item == Item.ItemType.Reksi)
        {
            Fungus.Flowchart.BroadcastFungusMessage("ReksiWrong");
        }
        else if (item == Item.ItemType.Jake)
        {
            Fungus.Flowchart.BroadcastFungusMessage("JakeWrong");
        }
        else if (item == Item.ItemType.Jacques)
        {
            Fungus.Flowchart.BroadcastFungusMessage("HanskiWrong");
        }
    }
}
