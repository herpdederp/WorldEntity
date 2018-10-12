using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{

    private void OnMouseDown()
    {


        var evnt = CubeEvent.Create(GameObject.Find("WorldEntity(Clone)").GetComponent<BoltEntity>());
        evnt.Index = transform.GetSiblingIndex();
        evnt.Send();
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
