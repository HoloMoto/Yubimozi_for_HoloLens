using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class JapaneeseKeyBoard : MonoBehaviour
{
    [Serializable] public class MyEvemt :UnityEvent<string>
    {}
    
    [SerializeField] private MyEvemt _Keyevent;
    private string _Field;
    [SerializeField] private TextMeshPro _text;

    [SerializeField] private GameObject _keyboard;
    [SerializeField] private TextMeshPro _MasterText;

    //Saves the previous character and uses it to convert special characters.
    private string _lastNum;
    public void KeyInput(string number)
    {
        _lastNum = number;
        _Field += number;
        _Keyevent.Invoke(_Field);
    }

    public void BackSpace()
    {
        int _Dsize = _Field.Length-1;
        _Field = _Field.Remove(_Dsize, 1);
       _text.text = _Field;
       _lastNum = _Field.Substring(_Dsize - 1, 1);
    }

    public void SpatialKey(string SpKey)
    {
        switch (SpKey)
        {
            case "*":
                voicedSound();
                break;
            case "。":
                Psound();
                break;
            case "#":
                Small();
                break;
            case "$":
                _lastNum = " ";
                _Field += _lastNum;
                _Keyevent.Invoke(_Field);
                break;
        }
    }

    void voicedSound()
    {
        bool _textChange=false;
        switch (_lastNum)
        {
            #region　が～ご
            case "か":
                _lastNum = "が";
                _textChange = true;
                break;
            case "カ":
                _lastNum = "ガ";
                _textChange = true;
                break;
            case "き":
                _lastNum = "ぎ";
                _textChange = true;
                break;
            case "キ":
                _lastNum = "ギ";
                _textChange = true;
                break;
            case "く":
                _lastNum = "ぐ";
                _textChange = true;
                break;
            case "ク":
                _lastNum = "グ";
                _textChange = true;
                break;
            case "け":
                _lastNum = "げ";
                _textChange = true;
                break;
            case "ケ":
                _lastNum = "ゲ";
                _textChange = true;
                break;
            case "こ":
                _lastNum = "ご";
                _textChange = true;
                break;
            case "コ":
                _lastNum = "ゴ";
                _textChange = true;
                break;
            #endregion

                #region さ~そ

            case "さ":
                _lastNum = "ざ";
                _textChange = true;
                break;
            case "サ":
                _lastNum = "ザ";
                _textChange = true;
                break;
            case "し":
                _lastNum = "じ";
                _textChange = true;
                break;
            case "シ":
                _lastNum = "ジ";
                _textChange = true;
                break;
            case "す":
                _lastNum = "ず";
                _textChange = true;
                break;
            case "ス":
                _lastNum = "ズ";
                _textChange = true;
                break;
            case "せ":
                _lastNum = "ぜ";
                _textChange = true;
                break;
            case "セ":
                _lastNum = "ゼ";
                _textChange = true;
                break;
            case "そ":
                _lastNum = "ぞ";
                _textChange = true;
                break;
            case "ソ":
                _lastNum = "ゾ";
                _textChange = true;
                break;

            #endregion

                #region た～と
            case "た":
                _lastNum = "だ";
                _textChange = true;
                break;
            case "タ":
                _lastNum = "ダ";
                _textChange = true;
                break;
            case "ち":
                _lastNum = "ぢ";
                _textChange = true;
                break;
            case "チ":
                _lastNum = "ヂ";
                _textChange = true;
                break;
            case "つ":
                _lastNum = "づ";
                _textChange = true;
                break;
            case "ツ":
                _lastNum = "ヅ";
                _textChange = true;
                break;
            case "て":
                _lastNum = "で";
                _textChange = true;
                break;
            case "テ":
                _lastNum = "デ";
                _textChange = true;
                break;
            case "と":
                _lastNum = "ど";
                _textChange = true;
                break;
            case "ト":
                _lastNum = "ド";
                _textChange = true;
                break;
                

            #endregion

                #region は～ほ
            case "は":
                _lastNum = "ば";
                _textChange = true;
                break;
            case "ハ":
                _lastNum = "バ";
                _textChange = true;
                break;
            case "ひ":
                _lastNum = "び";
                _textChange = true;
                break;
            case "ヒ":
                _lastNum = "ビ";
                _textChange = true;
                break;
            case "フ":
                _lastNum = "ブ";
                _textChange = true;
                break;
            case "ふ":
                _lastNum = "ぶ";
                _textChange = true;
                break;
            case "へ":
                _lastNum = "べ";
                _textChange = true;
                break;
            case "ヘ":
                _lastNum = "ベ";
                _textChange = true;
                break;
            case "ほ":
                _lastNum = "ぼ";
                _textChange = true;
                break;
            case "ホ":
                _lastNum = "ボ";
                _textChange = true;
                break;
                

            #endregion
            default:
                _textChange = false;
                break;
        }

        if (_textChange)
        {
            int _Dsize = _Field.Length-1;
            _Field = _Field.Remove(_Dsize, 1);
            Debug.Log(_lastNum);
            _text.text = _Field;
            _Field += _lastNum;
            _Keyevent.Invoke(_Field);
        }
    
    }
    
    void Psound()
    {
        bool _textChange=false;
        switch (_lastNum)
        {
            #region　ぱ～ぽ

            case "は":
                _lastNum = "ぱ";
                _textChange = true;
                break;
            case "ハ":
                _lastNum = "パ";
                _textChange = true;
                break;
            case "ヒ":
                _lastNum = "ピ";
                _textChange = true;
                break;
            case "ひ":
                _lastNum = "ぴ";
                _textChange = true;
                break;
            case "ふ":
                _lastNum = "ぷ";
                _textChange = true;
                break;
            case "フ":
                _lastNum = "プ";
                _textChange = true;
                break;
            case "ヘ":
                _lastNum = "ぺ";
                _textChange = true;
                break;
            case "へ":
                _lastNum = "ぺ";
                _textChange = true;
                break;
            case "ほ":
                _lastNum = "ぽ";
                _textChange = true;
                break;
            case "ホ":
                _lastNum = "ポ";
                _textChange = true;
                break;

            #endregion
        }
        if (_textChange)
        {
            int _Dsize = _Field.Length-1;
            _Field = _Field.Remove(_Dsize, 1);
            Debug.Log(_lastNum);
            _text.text = _Field;
            _Field += _lastNum;
            _Keyevent.Invoke(_Field);
        }
    }

    void Small()
    {
        bool _textChange=false;
        switch (_lastNum)
        {
           case "つ" :
               _lastNum = "っ";
               _textChange = true;
               break;
               case "や":
                   _lastNum = "ゃ";
                   _textChange = true;
                   break;
               case  "ゆ":
                   _lastNum = "ゅ";
                   _textChange = true;
                   break;
                   case  "よ":
                       _lastNum = "ょ";
                       _textChange = true;
                       break;
           case  "あ":
               _lastNum = "ぁ";
               _textChange = true;
               break;
           case  "い":
               _lastNum = "ぃ";
               _textChange = true;
               break;
           case  "う":
               _lastNum = "ぅ";
               _textChange = true;
               break;
           case  "え":
               _lastNum = "ぇ";
               _textChange = true;
               break;
           case  "お":
               _lastNum = "ぉ";
               _textChange = true;
               break;

        }
        if (_textChange)
        {
            int _Dsize = _Field.Length-1;
            _Field = _Field.Remove(_Dsize, 1);
            Debug.Log(_lastNum);
            _text.text = _Field;
            _Field += _lastNum;
            _Keyevent.Invoke(_Field);
        }
    }
    public void HideKeyboard()
    {
        _keyboard.SetActive(false);
        TextFielddele();
    }

    public void TextFielddele()
    {
        _Field = null;
        _text.text = "text";
    }

    public void TextSent()
    {
        _MasterText.text= _Field;
    }


}


