using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YubimoziHandController : MonoBehaviour
{
    [SerializeField] private Collider _col;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void ColliderActiveOrDeactive()
    {
        _col.enabled = !_col.enabled;
    }
}
