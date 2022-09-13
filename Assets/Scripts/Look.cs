using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Look : MonoBehaviour
{
    [SerializeField] private Transform target;

    [SerializeField] private int x;
    [SerializeField] private int y;
    [SerializeField] private int z;

    void Update()
    {
        transform.LookAt(target);
        transform.Rotate(x, y, z);
    }
}
