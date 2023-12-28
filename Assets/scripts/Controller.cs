using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var _position = Camera.main.transform.position + Camera.main.transform.forward * 1.7f;
        this.transform.position = new Vector3(_position.x, this.transform.position.y, _position.z);
    }
}
