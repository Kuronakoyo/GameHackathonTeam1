using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LifeGauge : MonoBehaviour
{
    //�@���C�t�Q�[�W�v���n�u
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


    //�@���C�t�Q�[�W�S�폜��HP���쐬
    public void SetLifeGauge()
    {
        //�@�̗͂���U�S�폜
        for (int i = 0; i < transform.childCount; i++)
        {
            Destroy(transform.GetChild(i).gameObject);
        }
        //�@���݂̗̑͐����̃��C�t�Q�[�W���쐬
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
