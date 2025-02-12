using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouvementRotate : MonoBehaviour
{

    void Update()
    {
        transform.Rotate(0f, Time.deltaTime * 60f, 0f);
    }
}
