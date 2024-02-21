using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ChangSprite : MonoBehaviour
{
    [SerializeField] private Sprite menuImage;

    // Start is called before the first frame update
    void Start()
    {
        Image image = GetComponent<Image>();
        if (image != null)
        {
            image.sprite = menuImage;
        }

    }
}
