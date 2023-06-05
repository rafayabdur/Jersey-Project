using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FontStyle : MonoBehaviour
{
    [SerializeField] private Text text;
    [SerializeField] private InputField inputField;

    public List<Font> fontFamily = new List<Font>();

    public RectTransform textTransform;

  

    //public List<Font> fontStyle = new List<Font>();

    public void OnBoldBtn_Click()
    {
        text.fontStyle = UnityEngine.FontStyle.Bold;
    }

    public void OnItaliacBtn_Click()
    {
        text.fontStyle = UnityEngine.FontStyle.Italic;
    }

    public void OnFontFamilySelection(int index)
    {
        for (int i = 0; i < fontFamily.Count; i++)
        {
            text.font = fontFamily[index];
        }


    }

    public void OnUpBtn_Click()
    {
        Debug.Log("IN 1");
        if (textTransform.localPosition.y < 0.1 )
        {
            Debug.Log("IN 1");
            //textTransform.position = new Vector2(textTransform.position.x, textTransform.position.y - (float)0.01);
            textTransform.position = new Vector3(textTransform.position.x, textTransform.position.y - 0.01f, textTransform.position.z );
        }
    }
    public void OnDownBtn_Click()
    {
        if (textTransform.localPosition.y >= -1.98)
        {
            Debug.Log("In 2");
            textTransform.position = new Vector3(textTransform.position.x, textTransform.position.y + 0.01f,textTransform.position.z);
        }    
    }
    public void OnSizeUp_Click()
    {
        if (textTransform.sizeDelta.x <= 1)
        {
            textTransform.sizeDelta = new Vector2(textTransform.sizeDelta.x + 0.1f, textTransform.sizeDelta.y + 0.1f);
        }
    }
    public void OnSizeDown_Click()
    {
        if (textTransform.sizeDelta.x > 0.4)
        {
            textTransform.sizeDelta = new Vector2(textTransform.sizeDelta.x - 0.1f, textTransform.sizeDelta.y - 0.1f);
        }
    }

    public void OnValueChange() {
        text.text = inputField.text;
    }

    //public void OnFontStyleBtn_Click(int index)
    //{
    //    for (int i = 0; i < fontStyle.Count; i++)
    //    {
    //        GetComponent<Text>().font = fontStyle[index];
    //    }
    //}
}
