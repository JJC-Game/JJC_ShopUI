using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MenuItem : MonoBehaviour
{
    Image icon;
    Text text;
    // Start is called before the first frame update
    void Awake()
    {
        icon = transform.Find("Icon").GetComponent<Image>();
        text = transform.Find("Text").GetComponent<Text>();
    }

    public void SetItemData(ItemFixData itemFixData)
    {
        icon.sprite = itemFixData._iconSprite;
        text.text = itemFixData._name;
    }
}
