using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour
{
    // �{�[���̈ړ��̑������w�肷��ϐ�
    public float speed = 5f;
    Rigidbody2D myRigidbody;
    // Start is called before the first frame update
    void Start()
    {
        // Rigidbody�ɃA�N�Z�X���ĕϐ��ɕێ����Ă���
        GetComponent<Rigidbody2D>().AddForce(new Vector3(speed, speed, 0) * speed);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Alien")
        {
            Destroy(other.gameObject);
        }
        Debug.Log("���蔲�����I");
    }
    void ball()
    {
        GameObject obj = (GameObject)Resources.Load("Ball");
        

    }
}
