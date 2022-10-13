using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchedWall : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
}
