using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowAndHide : MonoBehaviour
{
  [SerializeField] private bool _defalutStatus;
  
  
  private bool _TorF;

  private void Start()
  {
    gameObject.SetActive(_defalutStatus);
  }

  public void ShowHide()
  {
    _TorF = !this.gameObject.activeSelf;
    Debug.Log(_TorF);
    this.gameObject.SetActive(_TorF);
  }


}
