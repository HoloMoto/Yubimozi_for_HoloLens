using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;
using TMPro;
using Microsoft.MixedReality.Toolkit.Input;
using Microsoft.MixedReality.Toolkit.UI;

public class YubimoziRender : MonoBehaviour
{
    [SerializeField] private TextMeshPro _MasterText;
    [SerializeField] private TextMeshPro _text;
    [SerializeField]
    private string[] _TextList;
    private string _addText;

    [SerializeField] private TextMeshPro _HandText;
    public float _speed =1;
    [SerializeField] private Animator _anim;


 

    public void YubimoziRead()
    {

        int _textsize = _text.text.Length;
        _TextList = new string[_textsize];
        Debug.Log(_textsize);
        string _refreshText =_text.text;
        int i ;
        for(i =0; i<_textsize;i++)
        {
            _addText =_refreshText.Substring(0, 1);
             _refreshText = _refreshText.Remove(0, 1);
            Debug.Log(_refreshText);
            _TextList[i] = _addText;
        }
        YubimoziAnimatior();
    }

    void YubimoziAnimatior()
    {
        StartCoroutine("AnimatoinSwitch");
    }

    public void ChangeReadingSpeed(SliderEventData eventData)
    {
        
        _speed = 3.0f * (eventData.NewValue+0.5f);
    }
    
    /// <summary>
    /// Performs animation of text entered by voice input.
    /// </summary>
    public void YubimoziAzureSent()
    {
        StartCoroutine("AzreSent");
    }

    IEnumerator AzreSent()
    {
        yield return new WaitForSeconds(2);
        int _textsize = _MasterText.text.Length;
        _TextList = new string[_textsize];
        Debug.Log(_textsize);
        string _refreshText =_MasterText.text;
        int i ;
        for(i =0; i<_textsize;i++)
        {
            _addText =_refreshText.Substring(0, 1);
            _refreshText = _refreshText.Remove(0, 1);
            Debug.Log(_refreshText);
            _TextList[i] = _addText;
        }
        YubimoziAnimatior();   
    }
    /// <summary>
    /// Split the text one character at a time and perform an animation for each character.
    ///It is currently redundant and will need to be improved in the near future using dictionary types, etc.
    /// </summary>
    IEnumerator AnimatoinSwitch()
    {
        int _textsize= _TextList.Length;
        int i;
        for (i = 0; i < _textsize; i++)
        {
            string source = _TextList[i];
            Debug.Log(source);
            _HandText.text = source;
            switch (source)
            {
                #region Japanesse
                   case "あ":
                       case "ア":
                       _anim.SetTrigger("A");
                    break;
                case "い":
                    case "イ":
                    _anim.SetTrigger("I");
                    break;
                case "う":
                  case "ウ":
                    _anim.SetTrigger("U");
                    break;
                case "え":
                 case "エ":
                    _anim.SetTrigger("E");
                    break;
                case "お":
                    case "オ":
                    _anim.SetTrigger("O");
                    break;
                case "か":
                 case "カ":
                    _anim.SetTrigger("Ka");
                    break;
                case "き":
                    case "キ":
                    _anim.SetTrigger("Ki");
                    break;
                case "く":
                  case "ク":
                    _anim.SetTrigger("Ku");
                    break;
                case "け":
                case "ケ":
                    _anim.SetTrigger("Ke");
                    break;
                case "こ":
                case "コ":
                    _anim.SetTrigger("Ko");
                    break;
                case "さ":
                    case "サ":
                    _anim.SetTrigger("Sa");
                    break;
                case "し":
                case "シ":
                    _anim.SetTrigger("Si");
                    break;
                case "す":
                case "ス":
                    _anim.SetTrigger("Su");
                    break;
                case "せ":
                case "セ":
                    _anim.SetTrigger("Se");
                    break;
                case "そ":
                case "ソ":
                    _anim.SetTrigger("So");
                    break;
                case "た":
                    case "タ":
                    _anim.SetTrigger("Ta");
                    break;
                case "ち":
                  case "チ":
                    _anim.SetTrigger("Ti");
                    break;
                case "つ":
                  case "ツ":
                    _anim.SetTrigger("Tu");
                    break;
                case "て":
                case "テ":
                    _anim.SetTrigger("Te");
                    break;
                case "と":
                  case "ト":
                    _anim.SetTrigger("To");
                    break; 
                case "な":
                    case "ナ":
                    _anim.SetTrigger("Na");
                    break; 
                case "に":
                case "ニ":
                    _anim.SetTrigger("Ni");
                    break; 
                case "ぬ":
                case "ヌ":
                    _anim.SetTrigger("Nu");
                    break; 
                case "ね":
                case "ネ":
                    _anim.SetTrigger("Ne");
                    break; 
                case "の":
                case "ノ":
                    _anim.SetTrigger("No");
                    break; 
                case "は":
                    case "ハ":
                    _anim.SetTrigger("Ha");
                    break; 
                case "ひ":
                case "ヒ":
                    _anim.SetTrigger("Hi");
                    break; 
                case "ふ":
                case "フ":
                    _anim.SetTrigger("Hu");
                    break; 
                case "へ":
                 case "ヘ":
                    _anim.SetTrigger("He");
                    break; 
                case "ほ":
                case "ホ":
                    _anim.SetTrigger("Ho");
                    break; 
                case "ま":
                    case "マ":
                    _anim.SetTrigger("Ma");
                    break; 
                case "み":
              　  case "ミ":
                    _anim.SetTrigger("Mi");
                    break; 
                case "む":
               　 case "ム":
                    _anim.SetTrigger("Mu");
                    break; 
                case "め":
               　 case "メ":
                    _anim.SetTrigger("Me");
                    break; 
                case "も":
                　case "モ":
                    _anim.SetTrigger("Mo");
                    break; 
                
                case "や":
                    case "ヤ":
                    _anim.SetTrigger("Ya");
                    break; 
                case "ゆ":
                case "ユ":
                    _anim.SetTrigger("Yu");
                    break; 
                case "よ":
                case "ヨ":
                    _anim.SetTrigger("Yo");
                    break; 
                case "ら":
                    case  "ラ":
                    _anim.SetTrigger("Ra");
                    break; 
                case "り":
                case  "リ":
                    _anim.SetTrigger("Ri");
                    break; 
                case "る":
                case  "ル":
                    _anim.SetTrigger("Ru");
                    break; 
                case "れ":
                case  "レ":
                    _anim.SetTrigger("Re");
                    break; 
                case "ろ":
                case  "ロ":
                    _anim.SetTrigger("Ro");
                    break; 
                case "わ":
                    case  "ワ":
                    _anim.SetTrigger("Wa");
                    break; 
                case "を":
                case  "ヲ":
                    _anim.SetTrigger("Wo");
                    break; 
                case "ん":
                case  "ン":
                    _anim.SetTrigger("NN");
                    break;
                case "が" :
                case "ガ":
                    _anim.SetTrigger("Ga");
                    break;
                case "ぎ" :
                case "ギ":
                    _anim.SetTrigger("Gi");
                    break;
                case "ぐ":
                case "グ":
                    _anim.SetTrigger("Gu");
                    break;
                case "げ" :
                case "ゲ":
                    _anim.SetTrigger("Ge");
                    break;
                case "ご" :
                case "ゴ":
                    _anim.SetTrigger("Go");
                    break;
                case "ざ":
                    case "ザ":
                    _anim.SetTrigger("Za");
                    break;
                case "じ":
                case "ジ":
                    _anim.SetTrigger("Zi");
                    break;
               
                case "ず":
                case "ズ":
                    _anim.SetTrigger("Zu");
                    break;
               
                case "ぜ":
                case "ゼ":
                    _anim.SetTrigger("Ze");
                    break;
               
                case "ぞ":
                case "ゾ":
                    _anim.SetTrigger("Zo");
                    break;
                case "だ":
                case "ダ":
                    _anim.SetTrigger("Do");
                    break;
                case "ヂ":
                case "ぢ":
                    _anim.SetTrigger("Di");
                    break;
                case "づ":
                case "ヅ":
                    _anim.SetTrigger("Du");
                    break;
                case "で":
                case "デ":
                    _anim.SetTrigger("De");
                    break;
                case "ど":
                case "ド":
                    _anim.SetTrigger("Do");
                    break;
                case "ば":
                case "バ":
                    _anim.SetTrigger("Ba");
                    break;
                case "び":
                case "ビ":
                    _anim.SetTrigger("Bo");
                    break;
                case "ぶ":
                case "ブ":
                    _anim.SetTrigger("Bu");
                    break;
                case "べ":
                case "ベ":
                    _anim.SetTrigger("Be");
                    break;
                case "ぼ":
                case "ボ":
                    _anim.SetTrigger("Bo");
                    break;
                case "ぱ":
                case "パ":
                    _anim.SetTrigger("Pa");
                    break;
                case "ぴ":
                case "ピ":
                    _anim.SetTrigger("Pi");
                    break;
                case "ぷ":
                case "プ":
                    _anim.SetTrigger("Pu");
                    break;
                case "ぺ":
                case "ペ":
                    _anim.SetTrigger("Pe");
                    break;
                case "ぽ":
                case "ポ":
                    _anim.SetTrigger("Po");
                    break;
                case "ぁ":
                case "ァ":
                    _anim.SetTrigger("sA");
                    break;
                case "ぃ":
                case "ィ":
                    _anim.SetTrigger("sI");
                    break;
                case "ぅ":
                case "ゥ":
                    _anim.SetTrigger("sU");
                    break;
                case "ぇ":
                case "ェ":
                    _anim.SetTrigger("sE");
                    break;
                case "ぉ":
                case "ォ":
                    _anim.SetTrigger("sO");
                    break;
                case "っ":
                case "ッ":
                    _anim.SetTrigger("sTsu");
                    break;
                case "ゃ":
                case "ャ":
                    _anim.SetTrigger("sYa");
                    break;
                case "ゅ":
                case "ュ":
                    _anim.SetTrigger("sYu");
                    break;
                case "ょ":
                case "ョ":
                    _anim.SetTrigger("sYo");
                    break;
              #endregion
                case "A" :
                    case "a":
                    _anim.SetTrigger("A");
                    break;
                case "B" :
                    case "b" :
                    _anim.SetTrigger("Ke");
                    break;
                case "C" :
                    case "c":
                    _anim.SetTrigger("EngC");
                    break;
                case "D" :
                    case "d":
                    _anim.SetTrigger("EngD");
                    break;
                case "E" :
                    case "e":
                    _anim.SetTrigger("E");
                    break;
                case "F" :
                    case "f":
                    _anim.SetTrigger("Me");
                    break;
                case "G" :
                    case "g":
                    _anim.SetTrigger("EngG");
                    break;
                case "H" :
                    case "h":
                    _anim.SetTrigger("Ha");
                    break;
                case "I" :
                    case "i":
                    _anim.SetTrigger("I");
                    break;
                case "J" :
                    case "j":
                    _anim.SetTrigger("EngJ");
                    break;
                case "K" :
                    case "k":
                    _anim.SetTrigger("Ka");
                    break;
                case "L" :
                    case "l":
                    _anim.SetTrigger("Re");
                    break;
                case "M" :
                    case "m":
                    _anim.SetTrigger("Ma");
                    break;
                case "N" :
                    case "n":
                    _anim.SetTrigger("Na");
                    break;
                case "O" :
                    case "o":
                    _anim.SetTrigger("O");
                    break;
                case "P" :
                    case "p":
                    _anim.SetTrigger("EngP");
                    break;
                case "Q" :
                    case "q" :
                    _anim.SetTrigger("EngQ");
                    break;
                case "R" :
                    case "r":
                    _anim.SetTrigger("Ra");
                    break;
                case "S" :
                    case "s":
                    _anim.SetTrigger("Sa");
                    break;
                case "T" :
                    case "t":
                    _anim.SetTrigger("EngT");
                    break;
                case "U" :
                    case "u":
                    _anim.SetTrigger("U");
                    break;
                case "V" :
                    case "v":
                    _anim.SetTrigger("EngV");
                    break;
                case "W" :
                    case "w":
                    _anim.SetTrigger("EngW");
                    break;
                case "X" :
                    case "x":
                    _anim.SetTrigger("Nu");
                    break;
                case "Y" :
                    case "y" :
                    _anim.SetTrigger("Yu");
                    break;
                case "Z" :
                    case "z":
                    _anim.SetTrigger("EngZ");
                    break;
            }
            yield return new WaitForSeconds(_speed);
        }

        
        
      
        
    }
    
}
