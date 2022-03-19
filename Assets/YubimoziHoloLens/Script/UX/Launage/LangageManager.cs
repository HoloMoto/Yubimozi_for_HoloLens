using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LangageManager : MonoBehaviour
{
    public bool _isJapaneese=false;
    public bool _isEnglish=false;

    // Start is called before the first frame update
    void Start()
    {
        string lang = Application.systemLanguage.ToString();
        //select App UI laungage from system laungage
        if (lang == "Japanese")
        {
            _isJapaneese = true;

        }
        else
        {
            _isEnglish = true;

        }
    }

    public void LaungageChange()
    {
        _isJapaneese = !_isJapaneese;
        _isEnglish = !_isEnglish;
    }
}
