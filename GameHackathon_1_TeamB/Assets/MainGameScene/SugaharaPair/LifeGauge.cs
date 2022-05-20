using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LifeGauge : MonoBehaviour
{
    //　ライフゲージプレハブ
    [SerializeField]
    private GameObject lifeObj;

    public int hp;


    private void Start()
    {
        SetLifeGauge();

    }
        //private void Update()
        //{
        //    if (Input.GetKeyDown(KeyCode.A))
        //    {
        //    SubHp();
        //    }

        //}

    public void SubHp()
    {
        hp--;
        SetLifeGauge();
    }


    //　ライフゲージ全削除＆HP分作成
    public void SetLifeGauge()
    {
        //　体力を一旦全削除
        for (int i = 0; i < transform.childCount; i++)
        {
            Destroy(transform.GetChild(i).gameObject);
        }
        //　現在の体力数分のライフゲージを作成
        for (int i = 0; i < hp; i++)
        {
            Instantiate<GameObject>(lifeObj, transform);
        }
        if (hp <= 0)
        {
            SceneManager.LoadScene("Resultscreen(alien)");
        }
    }
 
}
