using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cursor : MonoBehaviour
{
    int currentIndex = 0;
    // Start is called before the first frame update
    void Start()
    {
    }



    // Update is called once per frame
    void Update()
    {
    }

    public void SetCurrentIndex(int index)
    {
        RectTransform rectTrans = transform as RectTransform;
        rectTrans.anchoredPosition = JJC_ShopUI.menu.GetCursorPosition(index);
        currentIndex = index;
    }

    public int GetCurrentIndex()
    {
        return currentIndex;
    }
}
