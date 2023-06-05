using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;

public class TextSettings : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI text;

    public List<TMP_FontAsset> fontFamily = new List<TMP_FontAsset>();

    public RectTransform textTransform;
    //public List<Font> fontStyle = new List<Font>();

    public void OnBoldBtn_Click()
    {
        text.fontStyle = FontStyles.Bold;
    }

    public void OnItaliacBtn_Click()
    {
        text.fontStyle = FontStyles.Italic;
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
        if (textTransform.localPosition.y < 100)
        {
            Debug.Log("IN 1");
            textTransform.position = new Vector2(textTransform.position.x, textTransform.position.y + 2);
        }
    }
    public void OnDownBtn_Click()
    {
        if (textTransform.localPosition.y >= 0)
        {
            Debug.Log("In 2");
            textTransform.position = new Vector2(textTransform.position.x, textTransform.position.y - 2);
        }
    }

    //public void OnFontStyleBtn_Click(int index)
    //{
    //    for (int i = 0; i < fontStyle.Count; i++)
    //    {
    //        GetComponent<Text>().font = fontStyle[index];
    //    }
    //}
}

