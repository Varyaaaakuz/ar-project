using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerSpawn : MonoBehaviour
{
    void Start()
    {
        var _position = Camera.main.transform.position + Camera.main.transform.forward * 1.1f;
        this.transform.position = new Vector3(_position.x, this.transform.position.y, _position.z);
    }
}
