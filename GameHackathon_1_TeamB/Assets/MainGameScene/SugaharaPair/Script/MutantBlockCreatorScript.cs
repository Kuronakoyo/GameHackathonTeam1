using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienBlockCreatorScript : MonoBehaviour
{
    [SerializeField]
    GameObject _mutantBlok;

    public float num; 


    private Vector3 _mousePosStart;

    private Vector3 _InstantiatePos;



    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            _mousePosStart = Input.mousePosition;

            _mousePosStart.z = 10f;

            _InstantiatePos = Camera.main.ScreenToWorldPoint(_mousePosStart);

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray))
                Instantiate(_mutantBlok,transform);
        }
    }

}
