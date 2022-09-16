using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereBejaviour : MonoBehaviour
{
    [SerializeField]
    private GameObject _endTest;
    [SerializeField]
    private CubeColorBehaviour _cubeColorBehaviour;


    private void OnTriggerEnter(Collider other)
    {
        _endTest.SetActive(true);
        _cubeColorBehaviour.ChangeColor();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
