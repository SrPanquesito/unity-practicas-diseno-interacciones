using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
    public Item item;
    public Image image;

    // Start is called before the first frame update
    void Start()
    {
        if(image != null && item != null) 
        {
            image.sprite = item.icon;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
