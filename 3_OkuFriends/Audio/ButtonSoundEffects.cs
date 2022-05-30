using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSoundEffects : MonoBehaviour
{
    public AudioClip notebookOpen;
    public AudioClip notebookClose;
    public AudioClip closeDialogue;
    public AudioSource audioSource;

    public void playSoundEffect()
    {
        audioSource.PlayOneShot(notebookOpen, 0.7f);
        audioSource.PlayOneShot(notebookClose, 0.7f);
        audioSource.PlayOneShot(closeDialogue, 0.7f);
    }

}
