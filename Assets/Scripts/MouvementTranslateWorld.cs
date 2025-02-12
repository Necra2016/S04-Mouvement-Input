using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MouvementTranslateWorld : MonoBehaviour
{
//    [SerializeReference] private float _vitesse = 0f;
//    [SerializeReference] private float _directionX = 0f;
//    [SerializeReference] private float _directionY = 0f;
//    [SerializeReference] private float _directionZ = 0f;

//    void Update()
//    {
//        transform.Translate(_directionX * Time.deltaTime * _vitesse, _directionY, _directionZ, Space.World);

//        //Vector3 deplacement = new Vector3(1f, 0, 0);
//        //transform.Translate(deplacement * Time.deltaTime, Space.World);
//    }


    [SerializeField] private Vector3 _deplacement;
    private void Update()
    {
        transform.Translate(_deplacement);
    }
}

