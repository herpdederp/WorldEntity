using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCallbacks : Bolt.GlobalEventListener
{

    public override void SceneLoadLocalDone(string map)
    {
        if (BoltNetwork.isServer)
        {
            BoltNetwork.Instantiate(BoltPrefabs.WorldEntity);
        }
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
