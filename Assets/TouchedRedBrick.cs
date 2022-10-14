using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchedRedBrick : MonoBehaviour
{
    public GameObject redWall;

    // Start is called before the first frame update
    void OnTriggerEnter(Collider collision)
    {
        Destroy(redWall);
    }
}
