using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeColorBehaviour : MonoBehaviour
{
    private MeshRenderer _mesh;
    // Start is called before the first frame update
    void Start()
    {
        _mesh = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    public void ChangeColor()
    {
        _mesh.material.color = Color.red;
    }
}
