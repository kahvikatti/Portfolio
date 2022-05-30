using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonChangeImage : MonoBehaviour
{
    public Button button;
    public Sprite spriteDefault;
    public Sprite spriteNew;
    
    void Start()
    {
        button = GetComponent<Button>();
        button.GetComponent<Image>().sprite = spriteDefault;
    }

    // Changes notebook image if player has a new sticker they haven't viewed yet. Changes back once the sticker has been viewed.
    void ChangeButtonSprite(bool newStickers = false)
    {
        if (newStickers == true)
        {
            button.GetComponent<Image>().sprite = spriteNew;
        }
        else
        {
            button.GetComponent<Image>().sprite = spriteDefault;
        }
    }
}
