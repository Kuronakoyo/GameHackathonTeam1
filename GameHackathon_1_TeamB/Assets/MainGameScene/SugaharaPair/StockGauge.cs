using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StockGauge : MonoBehaviour
{
    [SerializeField]
    private GameObject stockObj;

    public int alienStock;

    [SerializeField]
    private int alienStockMax;

    [SerializeField]
    private float stockCreateTime;


    private void Start()
    {
        SetAlienStock();

        StartCoroutine(AddAlienStock());
    }


    public void SubAlienStock()
    {
        alienStock--;
        SetAlienStock();
    }




    //�@���C�t�Q�[�W�S�폜��HP���쐬
    public void SetAlienStock()
    {
        //�@�̗͂���U�S�폜
        for (int i = 0; i < transform.childCount; i++)
        {
            Destroy(transform.GetChild(i).gameObject);
        }
        //�@���݂̗̑͐����̃��C�t�Q�[�W���쐬
        for (int i = 0; i < alienStock; i++)
        {
            Instantiate<GameObject>(stockObj, transform);
        }
    }

    IEnumerator AddAlienStock()
    {
        while (true)
        {
            yield return new WaitForSeconds(stockCreateTime);

            if (alienStock <  alienStockMax)
            {
                alienStock++;
                SetAlienStock();
            }

        }
    }
}
