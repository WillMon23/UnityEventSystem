using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class GameEventListener : MonoBehaviour , ILisitner
{

    [SerializeField]
    [Tooltip("The action to preform when the event is raised")]
    private Event _event;

    [SerializeField]
    [Tooltip("The action to preform when the event is raised")]
    private UnityEvent _actions = new UnityEvent();

    [SerializeField]
    [Tooltip("The game object will raise the event." +
        "Action are only preformed when this game object rasies the event. ")]
    private GameObject _intendedSender;


    public void Init(Event listenerEvent, GameObject sender = null)
    {
        _event = listenerEvent;
        _event.AddListener(this);
        _intendedSender = sender;
        _actions = null;
    }
    
    // Start is called before the first frame update
    void Start()
    {
        if(!_event)
          _event = ScriptableObject.CreateInstance<Event>();

        _event.AddListener(this);
    }


    private void AddAction(UnityAction action)
    {
        if(_actions == null)
            _actions= new UnityEvent();

        _actions.AddListener(action);
    }

    public void ClearAction()
    {
        _actions.RemoveAllListeners();
    }

    public void Invoke(GameObject sender = null)
    {
        if(_intendedSender == sender || _intendedSender == null)
        {
            _actions?.Invoke();
        }
    }
}
