using System.Collections;
using System.Collections.Generic;
using Microsoft.MixedReality.Toolkit.UI;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Microsoft.MixedReality.Toolkit.UI;

public class TextTranslation : MonoBehaviour
{
     TextMeshPro text;
     private string stext;
     [SerializeField] private LangageManager _lm;

     [SerializeField]
     private string _japaneeseText;

     bool appLaungjapa;
     bool appLaungEng;
     [SerializeField] private string _englishText;

     [SerializeField] private bool _isFlatTmpText;
     [SerializeField] private bool _isHLButton;
     
    // Start is called before the first frame update
    void Start()
    {
        if (_isFlatTmpText)
        {
            FlatTmpText();
        }

        if (_isHLButton)
        {
            HoloLensButtonText();
        }
    }

    public  void FlatTmpText()
    {
        text = this.GetComponent<TextMeshPro>();
        appLaungjapa  = _lm._isJapaneese;
        appLaungEng = _lm._isEnglish;
        Debug.Log(appLaungjapa);
        if (appLaungjapa)
        {
            text.text = _japaneeseText;
            Debug.Log("Japaneese");
        }
        else
        {
            text.text = _englishText;
            Debug.Log("English");
        }
    }

    public void HoloLensButtonText()
    {
        stext = this.GetComponent<ButtonConfigHelper>().MainLabelText;
          
        appLaungjapa  = _lm._isJapaneese;
        appLaungEng = _lm._isEnglish;
        if (appLaungjapa)
        {
            stext = _japaneeseText;
            Debug.Log("Japaneese");
        }
        else
        {
            stext = _englishText;
            Debug.Log("English");
        }
        
        
    }


}
