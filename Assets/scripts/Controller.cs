using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var _position = Camera.main.transform.position + Camera.main.transform.forward;
        this.transform.position = _position;
    }
}
