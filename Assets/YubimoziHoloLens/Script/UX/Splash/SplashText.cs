using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;
public class SplashText : MonoBehaviour
{
    [SerializeField] private TextMeshPro _Title;

    [SerializeField]
    private float _time;

    public UnityEvent _Event;
    [SerializeField] private float _1sttime;
    void Start()
    {
        StartCoroutine("Text");

    }

    // Update is called once per frame
    void Update()
    {
       // _time += Time.deltaTime;
    }
    
    IEnumerator  Text()
    {

        yield return new WaitForSeconds(_1sttime);

        _Event.Invoke();

    }
}
