using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fly : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        Debug.Log("Fly script added to: " + gameObject.name);
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody>().MovePosition(GetComponent<Rigidbody>().position + transform.forward * Time.deltaTime * 500f);
        if (Input.GetButton("Fire1"))
            transform.position += transform.forward * Time.deltaTime * 1500.0f;

        transform.Rotate(Input.GetAxis("Vertical"), 0.0f, -Input.GetAxis("Horizontal"));

        float terrainHeightWhereWeAre = Terrain.activeTerrain.SampleHeight(transform.position);

        if (terrainHeightWhereWeAre > transform.position.y)
        {
            transform.position = new Vector3(transform.position.x,
            terrainHeightWhereWeAre,
            transform.position.z);
        }
    }
}
