using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.UI;
using Microsoft.MixedReality.Toolkit.Utilities;
public class Settings : MonoBehaviour
{
    [SerializeField] private Interactable _SettingsUIJap;

    [SerializeField] private Interactable _SettingsUIEng;

    [SerializeField] private LangageManager _lm;
    // Start is called before the first frame update
    void Start()
    {
        if (_lm._isJapaneese)
        {
            _SettingsUIJap.IsToggled = true;
            _SettingsUIEng.IsToggled = false;

        }
        else
        {
            _SettingsUIJap.IsToggled = false;
            _SettingsUIEng.IsToggled = true;
        }

    }


}
