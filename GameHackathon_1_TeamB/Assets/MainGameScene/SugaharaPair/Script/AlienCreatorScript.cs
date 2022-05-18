using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienCreatorScript : MonoBehaviour
{
    [SerializeField]
    GameObject _mutantBlok;


    private Vector3 _mousePosStart;

    private Vector3 _InstantiatePos;

    [SerializeField]
    private float[] canCreatPos;

    GameObject stockUI;

    private void Start()
    {
        stockUI = GameObject.Find("StockUiPanel");
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && stockUI.GetComponent<StockGauge>().alienStock >0)
        {
            _mousePosStart = Input.mousePosition;

            _mousePosStart.z = 10f;

            _InstantiatePos = Camera.main.ScreenToWorldPoint(_mousePosStart);


            if(_InstantiatePos.x <= canCreatPos[0] && _InstantiatePos.x >= -canCreatPos[0] 
                    && _InstantiatePos.y >= canCreatPos[1])
            {
                stockUI.GetComponent<StockGauge>().SubAlienStock();
                Instantiate(_mutantBlok, _InstantiatePos, new Quaternion(0, 0, 0, 0));
            }

        }
    }

}

