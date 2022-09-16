using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Event")]
public class Event : ScriptableObject
{
    //All listener in the event
    private List<ILisitner> _listener;

    /// <summary>
    /// Adds a new listener
    /// </summary>
    /// <param name="lisitner">refrence to the listener</param>
    public void AddListener(ILisitner lisitner)
    {
        if(_listener == null)
            _listener = new List<ILisitner>();

        _listener.Add(lisitner);
    }

    /// <summary>
    /// Raises the event and invokes all listeners
    /// </summary>
    /// <param name="sender">The gamObject that raised this event</param>
    public void Raise(GameObject sender = null)
    {
        //Return if there are no listeners for this event
        if(_listener == null)
            return;
        
        //Tell each listeners in the list to preform whatever action
        ///they're waiting to do.
        foreach(ILisitner lisitner in _listener)    
            lisitner.Invoke(sender); 

    }
}
