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




    //　ライフゲージ全削除＆HP分作成
    public void SetAlienStock()
    {
        //　体力を一旦全削除
        for (int i = 0; i < transform.childCount; i++)
        {
            Destroy(transform.GetChild(i).gameObject);
        }
        //　現在の体力数分のライフゲージを作成
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
