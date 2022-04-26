using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NotebookManager : MonoBehaviour
{
    public GameObject panelNotepad;
    public GameObject panelSettings;
    public GameObject panelDeleteSave;

    public GameObject[] sticker;

    public int stickerNumber;
    public int currentSticker;

    DialogueManager dialogueManager;

    void Start()
    {
        dialogueManager = GetComponent<DialogueManager>();
        if (ES3.KeyExists("stickerNumber"))
            stickerNumber = ES3.Load<int>("stickerNumber");
    }

    public void OpenPanel()
    {
        if (panelNotepad != null)
        {
            bool isActive = panelNotepad.activeSelf;
            panelNotepad.SetActive(!isActive);
        }
    }

    public void OpenSettings()
    {
        if (panelSettings != null)
        {
            bool isActive = panelSettings.activeSelf;
            panelSettings.SetActive(!isActive);
        }
    }

    public void OpenDeleteSave()
    {
        if (panelDeleteSave != null)
        {
            bool isActive = panelDeleteSave.activeSelf;
            panelDeleteSave.SetActive(!isActive);
        }
    }

    //Reveals stickers in the notebook as player earns them. Saves progress using Easy Save.
    public void GetSticker()
    {
        stickerNumber++;

        if (dialogueManager.dialogueNumber >= 3)
        {
            sticker[0].SetActive(true);
            ES3.Save("stickerNumber", 0);
        }
        if (dialogueManager.dialogueNumber >= 4)
        {
            sticker[1].SetActive(true);
            ES3.Save("stickerNumber", 1);
        }
        if (dialogueManager.dialogueNumber >= 5)
        {
            sticker[2].SetActive(true);
            ES3.Save("stickerNumber", 2);
        }
        if (dialogueManager.dialogueNumber >= 6)
        {
            sticker[3].SetActive(true);
            ES3.Save("stickerNumber", 3);
        }
        if (dialogueManager.dialogueNumber >= 7)
        {
            sticker[4].SetActive(true);
            ES3.Save("stickerNumber", 4);
        }
        if (dialogueManager.dialogueNumber >= 8)
        {
            sticker[5].SetActive(true);
            ES3.Save("stickerNumber", 5);
        }
        if (dialogueManager.dialogueNumber >= 9)
        {
            sticker[6].SetActive(true);
            ES3.Save("stickerNumber", 6);
        }
        if (dialogueManager.dialogueNumber >= 10)
        {
            sticker[7].SetActive(true);
            ES3.Save("stickerNumber", 7);
        }
    }

    public void GetLastSticker()
    {
        sticker[8].SetActive(true);
        ES3.Save("stickerNumber", 8);
    }

    public void DeleteSave()
    {
        ES3.DeleteDirectory("myFolder/");
        PlayerPrefs.DeleteAll();
    }
}
