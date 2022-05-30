using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour
{
    [SerializeField] GameObject journal;
    [SerializeField] GameObject sortPanel;
    [SerializeField] GameObject catPage;

    public void OpenJournal()
    {
        if (journal != null)
        {
            bool isActive = journal.activeSelf;
            journal.SetActive(!isActive);
            sortPanel.SetActive(isActive);
        }
    }

    public void OpenCatPage()
    {
        if (catPage != null)
        {
            bool isActive = catPage.activeSelf;
            catPage.SetActive(!isActive);
        }
    }

    public void OpenSortPanel()
    {
        if (sortPanel != null)
        {
            bool isActive = sortPanel.activeSelf;
            sortPanel.SetActive(!isActive);
        }
    }
}
