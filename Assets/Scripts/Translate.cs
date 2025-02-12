using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Translate : MonoBehaviour
{

    private float _vitesse = 5f;


    // Start is called before the first frame update
    void Start()
    {
        _vitesse = Random.Range(1f, 10f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, _vitesse * Time.deltaTime, Space.Self);
        if (transform.position.x > 5f) { print(gameObject.name); }
    }
}
