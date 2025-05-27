using Newtonsoft.Json.Serialization;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackableAR : DefaultObserverEventHandler
{
    private bool marker;
    protected override void OnTrackingFound()
    {
        marker = true;
        base.OnTrackingFound();
        Debug.Log("found");
    }

    protected override void OnTrackingLost()
    {
        marker = false;
        base.OnTrackingLost();
        Debug.Log("hilang");
    }

    public bool GetMarker()
    {
        return marker;
    }
}
