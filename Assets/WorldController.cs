using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldController : Bolt.EntityEventListener<IWorldState>
{
    public Transform CubeRoot;

    public override void Attached()
    {

        CubeRoot = GameObject.Find("CubeRoot").transform;
        state.AddCallback("Cubes[]", (x, y, z) => { OnStatsChanged((IWorldState)x, (string)y, (Bolt.ArrayIndices)z); });

    }

    public void OnStatsChanged(IWorldState state, string path, Bolt.ArrayIndices indices)
    {

        int index = indices[0];

        int damage = state.Cubes[index];

        if (damage > 5)
            CubeRoot.GetChild(index).gameObject.SetActive(false);
        else
            CubeRoot.GetChild(index).GetComponent<MeshRenderer>().material.color = new Color(1 - (damage / 5f), 1 - (damage / 5f), 1 - (damage / 5f), 1);
    }

    public override void OnEvent(CubeEvent evnt)
    {
        state.Cubes[evnt.Index]++;
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
