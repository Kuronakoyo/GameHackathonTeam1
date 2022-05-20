using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour
{
    // ボールの移動の速さを指定する変数
    public float speed = 5f;
    Rigidbody2D myRigidbody;
    // Start is called before the first frame update
    void Start()
    {
        // Rigidbodyにアクセスして変数に保持しておく
        GetComponent<Rigidbody2D>().AddForce(new Vector3(speed, speed, 0) * speed);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Alien")
        {
            Destroy(other.gameObject);
        }
        Debug.Log("すり抜けた！");
    }
    void ball()
    {
        GameObject obj = (GameObject)Resources.Load("Ball");
        

    }
}
