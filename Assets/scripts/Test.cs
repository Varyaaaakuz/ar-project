using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    void Start()
    {
        var _position = Camera.main.transform.position + Camera.main.transform.forward * 3.5f;
        this.transform.position = new Vector3(_position.x, this.transform.position.y, _position.z);
    }
}
