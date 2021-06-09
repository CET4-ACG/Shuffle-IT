using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSprite : MonoBehaviour
{
    private SpriteRenderer rend;
    private Sprite firstTextbox, secondTextbox, thirdTextbox, fourthTextbox;
    
    private void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        
        firstTextbox = Resources.Load<Sprite>("lvl 1 bety");
        secondTextbox = Resources.Load<Sprite>("lvl 1 etby");
        thirdTextbox = Resources.Load<Sprite>("lvl 1 teyb");
        fourthTextbox = Resources.Load<Sprite>("lvl 1 ybet");
        rend.sprite = firstTextbox;
    }

    private void Update()
    {
        if (rend.sprite == firstTextbox)
        {
            ChangeImage();
            if (rend.sprite == secondTextbox)
            {
                ChangeImage();
                if (rend.sprite == thirdTextbox)
                {
                    ChangeImage();
                    if (rend.sprite == fourthTextbox)
                    {
                        ChangeImage();
                    }
                }
            }
        }
    }

    public void ChangeImage()
    {
        if (rend.sprite == firstTextbox)
        {
            rend.sprite = secondTextbox;
        }
        else if (rend.sprite == secondTextbox)
        {
            rend.sprite = thirdTextbox;
        }
        else if (rend.sprite == thirdTextbox)
        {
            rend.sprite = fourthTextbox;
        }
        else if (rend.sprite == fourthTextbox)
        {
            rend.sprite = firstTextbox;
        }
    }
}

