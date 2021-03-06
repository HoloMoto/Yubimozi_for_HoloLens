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
                   case "???":
                       case "???":
                       _anim.SetTrigger("A");
                    break;
                case "???":
                    case "???":
                    _anim.SetTrigger("I");
                    break;
                case "???":
                  case "???":
                    _anim.SetTrigger("U");
                    break;
                case "???":
                 case "???":
                    _anim.SetTrigger("E");
                    break;
                case "???":
                    case "???":
                    _anim.SetTrigger("O");
                    break;
                case "???":
                 case "???":
                    _anim.SetTrigger("Ka");
                    break;
                case "???":
                    case "???":
                    _anim.SetTrigger("Ki");
                    break;
                case "???":
                  case "???":
                    _anim.SetTrigger("Ku");
                    break;
                case "???":
                case "???":
                    _anim.SetTrigger("Ke");
                    break;
                case "???":
                case "???":
                    _anim.SetTrigger("Ko");
                    break;
                case "???":
                    case "???":
                    _anim.SetTrigger("Sa");
                    break;
                case "???":
                case "???":
                    _anim.SetTrigger("Si");
                    break;
                case "???":
                case "???":
                    _anim.SetTrigger("Su");
                    break;
                case "???":
                case "???":
                    _anim.SetTrigger("Se");
                    break;
                case "???":
                case "???":
                    _anim.SetTrigger("So");
                    break;
                case "???":
                    case "???":
                    _anim.SetTrigger("Ta");
                    break;
                case "???":
                  case "???":
                    _anim.SetTrigger("Ti");
                    break;
                case "???":
                  case "???":
                    _anim.SetTrigger("Tu");
                    break;
                case "???":
                case "???":
                    _anim.SetTrigger("Te");
                    break;
                case "???":
                  case "???":
                    _anim.SetTrigger("To");
                    break; 
                case "???":
                    case "???":
                    _anim.SetTrigger("Na");
                    break; 
                case "???":
                case "???":
                    _anim.SetTrigger("Ni");
                    break; 
                case "???":
                case "???":
                    _anim.SetTrigger("Nu");
                    break; 
                case "???":
                case "???":
                    _anim.SetTrigger("Ne");
                    break; 
                case "???":
                case "???":
                    _anim.SetTrigger("No");
                    break; 
                case "???":
                    case "???":
                    _anim.SetTrigger("Ha");
                    break; 
                case "???":
                case "???":
                    _anim.SetTrigger("Hi");
                    break; 
                case "???":
                case "???":
                    _anim.SetTrigger("Hu");
                    break; 
                case "???":
                 case "???":
                    _anim.SetTrigger("He");
                    break; 
                case "???":
                case "???":
                    _anim.SetTrigger("Ho");
                    break; 
                case "???":
                    case "???":
                    _anim.SetTrigger("Ma");
                    break; 
                case "???":
              ???  case "???":
                    _anim.SetTrigger("Mi");
                    break; 
                case "???":
               ??? case "???":
                    _anim.SetTrigger("Mu");
                    break; 
                case "???":
               ??? case "???":
                    _anim.SetTrigger("Me");
                    break; 
                case "???":
                ???case "???":
                    _anim.SetTrigger("Mo");
                    break; 
                
                case "???":
                    case "???":
                    _anim.SetTrigger("Ya");
                    break; 
                case "???":
                case "???":
                    _anim.SetTrigger("Yu");
                    break; 
                case "???":
                case "???":
                    _anim.SetTrigger("Yo");
                    break; 
                case "???":
                    case  "???":
                    _anim.SetTrigger("Ra");
                    break; 
                case "???":
                case  "???":
                    _anim.SetTrigger("Ri");
                    break; 
                case "???":
                case  "???":
                    _anim.SetTrigger("Ru");
                    break; 
                case "???":
                case  "???":
                    _anim.SetTrigger("Re");
                    break; 
                case "???":
                case  "???":
                    _anim.SetTrigger("Ro");
                    break; 
                case "???":
                    case  "???":
                    _anim.SetTrigger("Wa");
                    break; 
                case "???":
                case  "???":
                    _anim.SetTrigger("Wo");
                    break; 
                case "???":
                case  "???":
                    _anim.SetTrigger("NN");
                    break;
                case "???" :
                case "???":
                    _anim.SetTrigger("Ga");
                    break;
                case "???" :
                case "???":
                    _anim.SetTrigger("Gi");
                    break;
                case "???":
                case "???":
                    _anim.SetTrigger("Gu");
                    break;
                case "???" :
                case "???":
                    _anim.SetTrigger("Ge");
                    break;
                case "???" :
                case "???":
                    _anim.SetTrigger("Go");
                    break;
                case "???":
                    case "???":
                    _anim.SetTrigger("Za");
                    break;
                case "???":
                case "???":
                    _anim.SetTrigger("Zi");
                    break;
               
                case "???":
                case "???":
                    _anim.SetTrigger("Zu");
                    break;
               
                case "???":
                case "???":
                    _anim.SetTrigger("Ze");
                    break;
               
                case "???":
                case "???":
                    _anim.SetTrigger("Zo");
                    break;
                case "???":
                case "???":
                    _anim.SetTrigger("Do");
                    break;
                case "???":
                case "???":
                    _anim.SetTrigger("Di");
                    break;
                case "???":
                case "???":
                    _anim.SetTrigger("Du");
                    break;
                case "???":
                case "???":
                    _anim.SetTrigger("De");
                    break;
                case "???":
                case "???":
                    _anim.SetTrigger("Do");
                    break;
                case "???":
                case "???":
                    _anim.SetTrigger("Ba");
                    break;
                case "???":
                case "???":
                    _anim.SetTrigger("Bo");
                    break;
                case "???":
                case "???":
                    _anim.SetTrigger("Bu");
                    break;
                case "???":
                case "???":
                    _anim.SetTrigger("Be");
                    break;
                case "???":
                case "???":
                    _anim.SetTrigger("Bo");
                    break;
                case "???":
                case "???":
                    _anim.SetTrigger("Pa");
                    break;
                case "???":
                case "???":
                    _anim.SetTrigger("Pi");
                    break;
                case "???":
                case "???":
                    _anim.SetTrigger("Pu");
                    break;
                case "???":
                case "???":
                    _anim.SetTrigger("Pe");
                    break;
                case "???":
                case "???":
                    _anim.SetTrigger("Po");
                    break;
                case "???":
                case "???":
                    _anim.SetTrigger("sA");
                    break;
                case "???":
                case "???":
                    _anim.SetTrigger("sI");
                    break;
                case "???":
                case "???":
                    _anim.SetTrigger("sU");
                    break;
                case "???":
                case "???":
                    _anim.SetTrigger("sE");
                    break;
                case "???":
                case "???":
                    _anim.SetTrigger("sO");
                    break;
                case "???":
                case "???":
                    _anim.SetTrigger("sTsu");
                    break;
                case "???":
                case "???":
                    _anim.SetTrigger("sYa");
                    break;
                case "???":
                case "???":
                    _anim.SetTrigger("sYu");
                    break;
                case "???":
                case "???":
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
