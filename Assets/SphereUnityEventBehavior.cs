using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SphereUnityEventBehavior : MonoBehaviour
{
    [SerializeField]
    private UnityEvent _onCubeEnter;

    private void OnTriggerEnter(Collider other)
    {
        _onCubeEnter.Invoke();
    }
}
